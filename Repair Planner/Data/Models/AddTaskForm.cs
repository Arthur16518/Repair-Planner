using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class AddTaskForm
    {
        public string equipmentType { get; set; }

        public string equipmentModel { get; set; }

        public string serialNumber { get; set; }

        public string defects { get; set; }

        public string shortDescription { get; set; }

        public string condition { get; set; }

        public string clientPhoneNumber { get; set; }

        public string clientFirstName { get; set; }

        public string clientLastname { get; set; }
    }
}
