using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class Task
    {
        public int id { get; set; }

        public string equipmentType { get; set; }

        public string equipmentModel { get; set; }

        public string serialNumber { get; set; }

        public DateTime dateOfRecieving { get; set; }

        public bool isActive { get; set; }

        public string defects { get; set; }

        public string shortDescription { get; set; }

        public string condition { get; set; }

        public string taskCode { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
