using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class RequestCode
    {
        public int id { get; set; }

        public string code { get; set; }

        public DateTime dateOfAdding { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
