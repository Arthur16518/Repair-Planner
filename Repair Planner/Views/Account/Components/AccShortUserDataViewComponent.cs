using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Views.Account.Components
{
    public class AccShortUserDataViewComponent:ViewComponent
    {
        private PlannerDbContext dbContext;

        public AccShortUserDataViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public string Invoke(int userId)
        {
            User user = dbContext.Users.Find(userId);
            return user.lastName + " " + user.firstName + ", +" + user.phoneNumber + ", " + user.eMail;
        }
    }
}
