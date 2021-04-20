using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repair_Planner.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Repair_Planner.Controllers
{
    public class AccountController : Controller
    {
        PlannerDbContext dbContext;

        public AccountController(PlannerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInForm form)
        {
            if (ModelState.IsValid)
            {                
                User user = await dbContext.Users.FirstOrDefaultAsync(user => (user.logIn == form.logIn || user.eMail == form.logIn) && user.password == form.password);
                if (user != null)
                {
                    await Authenticate(form.logIn);
                    return RedirectToAction("Index", "Home");
                }
            }
            return MessageBox("Похоже, Вы ввели неверный логин или пароль");
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpForm form)
        {
            if (ModelState.IsValid)
            {
                User user = await dbContext.Users.FirstOrDefaultAsync(user => user.eMail == form.eMail || user.logIn == form.logIn);
                if (user == null)
                {
                    form.phoneNumber = Regex.Replace(form.phoneNumber, @"[^0-9]+", "");
                    int organizationId = dbContext.Organizations.FirstOrDefault(org => org.name == "empty").id;
                    if (form.requestCode != null)
                    {
                        RequestCode code = dbContext.Codes.FirstOrDefault(code => code.code == form.requestCode);
                        if (code != null)
                            if ((DateTime.Now - code.dateOfAdding).Hours <= 24)
                                organizationId = dbContext.Users.Find(code.UserId).OrganizationId;
                    }

                    user = new User
                    {
                        firstName = form.firstName,
                        lastName = form.lastName,
                        logIn = form.logIn,
                        password = form.password,
                        eMail = form.eMail,
                        OrganizationId = organizationId,
                        phoneNumber = form.phoneNumber
                    };
                    dbContext.Users.Add(user);
                    await dbContext.SaveChangesAsync();

                    await Authenticate(form.eMail);

                    return RedirectToAction("Index", "Home");
                }
            }
            return MessageBox("Похоже, пользователь с таким логином или электронной почтой уже существует. Проверьте данные и повторите попытку");
        }

        private async System.Threading.Tasks.Task Authenticate(string eMail)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, eMail)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Account");
        }

        public IActionResult MessageBox(string message)
        {
            ViewData["message"] = message;
            return View("Index");
        }

        public ActionResult CheckField(string field, string value)
        {
            bool result = false;
            switch(field)
            {
                case ("email"):
                    result = IsEmail(value);
                    break;
                case ("password"):
                    result = CheckPassword(value);
                    break;
                case ("confirmPassword"):
                    string[] passwords = value.Split('~');
                    try
                    {
                        result = passwords[0] == passwords[1];
                    }
                    catch { result = false; }
                    break;
                case ("logIn"):
                    result = !isLoginExist(value);
                    break;
                case ("phoneNumber"):
                    result = isPhoneNumber(value);
                    break;
            }
            return PartialView("CheckingMark", result);
        }

        private bool IsEmail(string email)
        {
            if (email == null)
                return false;
            if (dbContext.Users.Where(user => user.eMail == email).Any())
                return false;
            Regex regex = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            return regex.IsMatch(email);
        }

        private bool CheckPassword(string password)
        {
            if (password == null)
                return false;
            Regex regex = new Regex("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9,a-z,A-Z]{8,}");
            return regex.IsMatch(password);
        }

        private bool isLoginExist(string login)
        {
            if (login == null)
                return false;
            return dbContext.Users.Where(user => user.logIn == login).Any();
        }

        private bool isPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
                return false;
            Regex regex = new Regex(@"\+?\d+([\(\s\-]?\d+[\)\s\-]?[\d\s\-]+)?");
            return regex.IsMatch(phoneNumber);
        }

        public IActionResult RestorePasswordShow()
        {
            return View("RestorePassword");
        }

        [HttpPost]
        public IActionResult RestorePassword(string email)
        {
            string trueEmail = null;
            try
            {
                trueEmail = dbContext.Users.First(user => user.eMail == email || user.logIn == email).eMail;
            }
            catch { }
            bool result = false;
            if (trueEmail != null)
            {
                string newPassword = GeneratePassword();
                dbContext.Users.First(user => user.eMail == trueEmail).password = newPassword;
                dbContext.SaveChangesAsync();
                SendNewPassword(trueEmail, newPassword);
                result = true;
            }
            return View("RestorePasswordResult", result);
        }

        private void SendNewPassword(string email, string password)
        {
            MailAddress from = new MailAddress("repairplannersupp@gmail.com", "Поддержка Repair Planner");
            MailAddress to = new MailAddress(email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Восстановление пароля";
            m.Body = "<h2> Ваш новый пароль: "+password+"</h2>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("repairplannersupp@gmail.com", "a|)m1N0ne");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(m);
        }

        private string GeneratePassword()
        {
            string charSet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random randomizer = new Random();
            string result = "";
            for (int i = 0; i < 8; i++)
                result = result + charSet[randomizer.Next(charSet.Length)];
            return result;
        }

        [HttpGet]
        public IActionResult ViewTask(string taskCode)
        {
            Repair_Planner.Data.Models.Task task = null;
            taskCode = taskCode.Trim();
            try
            {
                task = dbContext.Tasks.First(t => t.taskCode == taskCode);
            }
            catch { }
            if (task == null)
                return View("TaskNotFound");
            else
                return View("ViewTask", task);
        }
    }
}