using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class Stage
    {
        public int id { get; set; }

        public string name { get; set; }

        public DateTime date { get; set; }

        public double cost { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
