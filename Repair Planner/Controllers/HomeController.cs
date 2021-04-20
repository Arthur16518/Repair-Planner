using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace Repair_Planner.Controllers
{
    public class HomeController : Controller
    {
        PlannerDbContext dbContext;

        public HomeController(PlannerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Authorize]
        public IActionResult Index()
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            Organization emptyOrg = dbContext.Organizations.First(org => org.name == "empty");
            if (currentUser.OrganizationId == emptyOrg.id)
                ViewData["userOrganization"] = "empty";
            return View();
        }

        [HttpPost]
        public IActionResult GetAddTask()
        {
            return PartialView("AddingWindow");
        }

        [HttpPost]
        public IActionResult AddTask(AddTaskForm taskForm)
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            taskForm.clientPhoneNumber = Regex.Replace(taskForm.clientPhoneNumber, @"[^0-9]+", "");
            IEnumerable<Client> clients = dbContext.Clients.Where(client => client.phoneNumber == taskForm.clientPhoneNumber && client.lastName == taskForm.clientLastname && client.firstName == taskForm.clientFirstName);
            if (clients.Any())
            {
                foreach (var client in clients)
                {
                    IEnumerable<Task> tasks = dbContext.Tasks.Where(task => task.ClientId == client.id && task.OrganizationId == currentUser.OrganizationId);
                    if (tasks.Any())
                    {
                        clients = dbContext.Clients.Where(c => c.id == client.id);
                        break;
                    }
                }
            }

            int clientId;
            if (!clients.Any())
            {
                Client client = new Client { 
                    firstName = taskForm.clientFirstName, 
                    lastName = taskForm.clientLastname, 
                    phoneNumber = taskForm.clientPhoneNumber 
                };
                dbContext.Clients.Add(client);
                dbContext.SaveChanges();
                clientId = client.id;
            }
            else
                clientId = clients.First().id;

            Task task = new Task
            {
                equipmentType = taskForm.equipmentType,
                equipmentModel = taskForm.equipmentModel,
                serialNumber = taskForm.serialNumber,
                defects = taskForm.defects,
                shortDescription = taskForm.shortDescription,
                condition = taskForm.condition,
                ClientId = clientId,
                OrganizationId = currentUser.OrganizationId,
                isActive = true,
                dateOfRecieving = DateTime.Now,
                taskCode = GenerateTaskCode()
            };
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();

            Stage firstStage = new Stage
            {
                cost = 0,
                date = DateTime.Now,
                name = "Добавлено",
                TaskId = task.id,
                UserId = currentUser.id
            };
            dbContext.Stages.Add(firstStage);
            dbContext.SaveChanges();

            return PartialView("AddingDone", task.taskCode);
        }

        private static string GenerateTaskCode()
        {
            string charSet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random randomizer = new Random();
            string result = "";
            for (int i = 0; i < 12; i++)
            {
                result = result + charSet[randomizer.Next(charSet.Length)];
                if (i == 3 || i == 7)
                    result = result + "-";
            }
            return result;
        }

        public IActionResult UpdateTaskList()
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            IEnumerable<Task> tasks = dbContext.Tasks.Where(task => task.OrganizationId == currentUser.OrganizationId);
            tasks = tasks.OrderByDescending(task => task.dateOfRecieving);
            tasks = tasks.OrderByDescending(task => task.isActive);
            return View("TaskList", tasks);
        }

        public IActionResult ShowTask(int taskId)
        {
            Task task = dbContext.Tasks.Find(taskId);
            return View("ViewTask", task);
        }

        public IActionResult ShowAddStageForm(int taskId)
        {
            return View("AddStageForm", taskId);
        }

        public string HideAddStageForm()
        {
            return "";
        }

        [HttpPost]
        public IActionResult AddStage(string date, string taskId, AddStageForm form)
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            int taskIdInt = Convert.ToInt32(taskId);
            double stageCost;
            DateTime dateTime;
            if (form.stageCost == null)
                form.stageCost = "0";
            try
            {
                form.stageCost = form.stageCost.Replace('.', ',');
                stageCost = Convert.ToDouble(form.stageCost);
                stageCost = Math.Round(stageCost, 2);
            }
            catch
            {
                stageCost = 0;
            }
            if (form.stageName == "Завершено")
                stageCost = 0;
            try
            {
                dateTime = Convert.ToDateTime(date);
            }
            catch
            {
                dateTime = DateTime.Now;
            }
            Stage newStage = new Stage
            {
                cost = stageCost,
                date = dateTime,
                name = form.stageName,
                TaskId = taskIdInt,
                UserId = currentUser.id
            };
            dbContext.Stages.Add(newStage);
            dbContext.SaveChanges();

            if (form.stageName == "Завершено")
            {
                dbContext.Tasks.Find(taskIdInt).isActive = false;
                dbContext.SaveChanges();
            }                
            Task task = dbContext.Tasks.Find(taskIdInt);            
            return ViewComponent("StageList", task);
        }

        public IActionResult GetTaskList(string type)
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            IEnumerable<Task> taskList;
            if (type == "all")
                return UpdateTaskList();
            else if (type == "active")
                taskList = dbContext.Tasks.Where(task => task.isActive && task.OrganizationId == currentUser.OrganizationId);
            else
                taskList = dbContext.Tasks.Where(task => !task.isActive && task.OrganizationId == currentUser.OrganizationId);
            taskList = taskList.OrderByDescending(task => task.dateOfRecieving);
            return View("TaskList", taskList);
        }

        public IActionResult GetOrgSignUpForm()
        {
            return View("OrgSignUpForm");
        }

        [HttpPost]
        public IActionResult AddOrganization(Organization form)
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            dbContext.Organizations.Add(form);
            dbContext.SaveChanges();
            dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name).OrganizationId = form.id;
            dbContext.SaveChanges();
            return View("Successfully", "Организация успешно зарегистрирована и привязана к этому пользователю");
        }

        public IActionResult CreateRequestCode()
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            RequestCode code = new RequestCode
            {
                dateOfAdding = DateTime.Now,
                UserId = currentUser.id,
                code = GenerateTaskCode()
            };
            dbContext.Codes.Add(code);
            dbContext.SaveChanges();
            return View("ShowCode", code.code);
        }

        public IActionResult GetInputCodeForm()
        {
            return View("InputCode");
        }

        [HttpPost]
        public IActionResult BindByCode(string code)
        {
            code = code.Trim();
            IEnumerable<RequestCode> codes = dbContext.Codes.Where(c => c.code == code);
            if (codes.Any())
            {
                dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name).OrganizationId = dbContext.Users.Find(codes.First().UserId).OrganizationId;
                dbContext.SaveChanges();
                return View("Successfully", "Теперь пользователь привязан к организации");
            }
            else
                return View("Wrongly", "Код недействителен");
        }

        public IActionResult Search(string request, string listName)
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            string[] tags;
            IEnumerable<Task> tasks;
            if (listName == "active-section")
                tasks = dbContext.Tasks.Where(task => task.OrganizationId == currentUser.OrganizationId && task.isActive);
            else if (listName == "completed-section")
                tasks = dbContext.Tasks.Where(task => task.OrganizationId == currentUser.OrganizationId && !task.isActive);
            else
                tasks = dbContext.Tasks.Where(task => task.OrganizationId == currentUser.OrganizationId);
            tags = new string[tasks.Count()];
            int i = 0;
            foreach (var task in tasks)
            {
                Client client = dbContext.Clients.Find(task.ClientId);
                tags[i] = task.id + " " + task.shortDescription.ToLower() + " " + task.taskCode + " " + task.serialNumber + " " + task.equipmentModel + " " + task.dateOfRecieving.ToShortDateString() + " " + client.phoneNumber + " " + client.lastName;
                i++;
            }
            string[] words = request.Split(' ');
            List<int> partialMatches = new List<int>();
            List<int> fullMatches = new List<int>();
            for(i = 0; i < tags.Length; i++)
            {
                bool isFullMatch = true, match = false;
                foreach (string word in words)
                {
                    if (tags[i].IndexOf(word) == -1)
                        isFullMatch = false;
                    else
                        match = true;
                }
                if (isFullMatch)
                    fullMatches.Add(i);
                if (match)
                    partialMatches.Add(i);
            }
            List<Task> results = new List<Task>();
            List<int> resultTags;
            if (fullMatches.Count == 0)
                resultTags = partialMatches;
            else
                resultTags = fullMatches;
            foreach(int tagNum in resultTags)
            {
                results.Add(tasks.First(t => t.id == Convert.ToInt32(tags[tagNum].Split(' ')[0])));
            }
            results = results.OrderByDescending(item => item.dateOfRecieving).ToList();
            results = results.OrderByDescending(item => item.isActive).ToList();
            return View("SearchResults", results);
        }

        public IActionResult UpdateStatistics()
        {
            return ViewComponent("Statistics");
        }
    }
}