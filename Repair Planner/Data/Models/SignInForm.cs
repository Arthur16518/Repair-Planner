using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class SignInForm
    {
        public string logIn { get; set; }

        public string password { get; set; }
    }
}
