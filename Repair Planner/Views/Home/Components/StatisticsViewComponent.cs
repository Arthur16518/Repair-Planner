using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Home.Components
{
    public class StatisticsViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public StatisticsViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public IViewComponentResult Invoke()
        {
            User currentUser = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            IEnumerable<Stage> stages = dbContext.Stages.Where(stage => stage.UserId == currentUser.id);
            stages = stages.Where(stage => (DateTime.Now - stage.date).Days <= 30);
            Statistics statistics = new Statistics(stages);
            return View("Statistics", statistics);
        }
    }
}
