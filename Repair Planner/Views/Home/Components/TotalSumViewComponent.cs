using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Home.Components
{
    public class TotalSumViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public TotalSumViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public string Invoke(IEnumerable<Stage> stages)
        {
            double sum = 0;
            foreach (var stage in stages)
            {
                sum += stage.cost;
            }
            sum *= SaleParameter(stages.First().TaskId);
            sum = Math.Round(sum, 2);
            return sum.ToString();
        }

        private double SaleParameter(int taskId)
        {
            Repair_Planner.Data.Models.Task task = dbContext.Tasks.Find(taskId);
            IEnumerable<Repair_Planner.Data.Models.Task> tasks = dbContext.Tasks.Where(t => t.dateOfRecieving <= task.dateOfRecieving && t.ClientId == task.ClientId);
            int times = tasks.Count();
            if (times != 1)
                if (times == 2)
                    return 0.98;
                else if (times <= 10)
                    return 0.95;
                else if (times <= 20)
                    return 0.9;
                else
                    return 0.85;
            else
                return 1;
        }
    }
}
