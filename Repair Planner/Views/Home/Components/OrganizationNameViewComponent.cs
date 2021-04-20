using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Home.Components
{
    public class OrganizationNameViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public OrganizationNameViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public string Invoke(int orgId)
        {
            return dbContext.Organizations.Find(orgId).name;
        }
    }
}
