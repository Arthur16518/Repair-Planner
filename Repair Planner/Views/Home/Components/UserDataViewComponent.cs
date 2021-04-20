using Microsoft.AspNetCore.Mvc;
using Repair_Planner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repair_Planner.Views;
using System.IO;

namespace Repair_Planner.Views.Home.Components
{
    public class UserDataViewComponent : ViewComponent
    {
        private PlannerDbContext dbContext;

        public UserDataViewComponent(PlannerDbContext context)
        {
            dbContext = context;
        }

        public IViewComponentResult Invoke()
        {
            User user = dbContext.Users.First(u => u.logIn == User.Identity.Name || u.eMail == User.Identity.Name);
            //string avatarPath = "Files/Avatars/" + user.id + ".jpg";
            //if (!File.Exists(avatarPath))
            //    avatarPath = "Files/Avatars/none.jpg";
            //if (File.Exists("wwwroot/Sources/avatar.jpg"))
            //    File.Delete("wwwroot/Sources/avatar.jpg");
            //File.Copy(avatarPath, "wwwroot/Sources/avatar.jpg");
            return View("UserData", user);
        }
    }
}
