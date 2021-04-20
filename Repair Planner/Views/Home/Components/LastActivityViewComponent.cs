using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Home.Components
{
    public class LastActivityViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public LastActivityViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public string Invoke(Repair_Planner.Data.Models.Task task)
        {
            IEnumerable<Stage> stages = dbContext.Stages.Where(stage => stage.TaskId == task.id);
            Stage lastStage = stages.First();
            foreach(var stage in stages)
            {
                if (stage.date > lastStage.date)
                    lastStage = stage;
            }
            return lastStage.name+" "+lastStage.date.Date.ToShortDateString();
        }
    }
}
