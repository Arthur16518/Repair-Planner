using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class User
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string logIn { get; set; }

        public string password { get; set; }

        public string eMail { get; set; }

        public string phoneNumber { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
