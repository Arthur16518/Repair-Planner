using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Home.Components
{
    public class ClientShortStringViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public ClientShortStringViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public string Invoke(Repair_Planner.Data.Models.Task task)
        {
            Client client = dbContext.Clients.Find(task.ClientId);
            return client.lastName+" "+client.firstName+", +"+client.phoneNumber;
        }
    }
}
