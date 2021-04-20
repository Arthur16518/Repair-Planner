using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair_Planner.Data.Models
{
    public class PlannerDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RequestCode> Codes { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Stage> Stages { get; set; }

        public PlannerDbContext(DbContextOptions<PlannerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
