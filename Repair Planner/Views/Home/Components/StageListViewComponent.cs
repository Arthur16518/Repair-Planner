using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Home.Components
{
    public class StageListViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public StageListViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public IViewComponentResult Invoke(Repair_Planner.Data.Models.Task task)
        {
            IEnumerable<Stage> stages = dbContext.Stages.Where(stage => stage.TaskId == task.id);
            stages = stages.OrderBy(stage => stage.date);
            return View("StageList", stages);
        }
    }
}
