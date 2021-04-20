using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner
{
    public class FillDb
    {
        public static void AddAdmin(PlannerDbContext context)
        {
            if (!context.Organizations.Any())
            {
                context.Organizations.Add(new Organization { description = "administrators", name = "Administration", adress = "none"});
                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.Add(new User { firstName = "Athur", lastName = "Vasilyev", logIn = "admin", password = "a|)m1N0ne", OrganizationId = 1});
                context.SaveChanges();
            } 
            if (!context.Organizations.Where(org => org.name == "empty").Any())
            {
                context.Organizations.Add(new Organization { description = "this organization for users without requests", name = "empty", adress = "none" });
                context.SaveChanges();
            }
        }
    }
}
