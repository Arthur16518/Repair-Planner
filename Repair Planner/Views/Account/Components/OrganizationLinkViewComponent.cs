using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Account.Components
{
    public class OrganizationLinkViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public OrganizationLinkViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public IViewComponentResult Invoke(Repair_Planner.Data.Models.Task task)
        {
            Organization organization = dbContext.Organizations.Find(task.OrganizationId);
            string linkContent = organization.name + ", "+organization.adress+", "+ organization.phone1+", "+organization.phone2;
            return new HtmlContentViewComponentResult(new HtmlString($"<p>"+linkContent+"</p>"));
        }
    }
}
