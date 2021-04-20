using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class Organization
    {
        public int id { get; set; }

        public string name { get; set; }

        public string adress { get; set; }

        public string phone1 { get; set; }

        public string phone2 { get; set; }

        public string description { get; set; }
    }
}
