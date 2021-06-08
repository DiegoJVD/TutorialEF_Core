using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEF_Core.Models;

namespace TutorialEF_Core.Dal
{
    public class SchoolContext : DbContext
    {
        public DbSet<Students> Student { get; set; }
        public DbSet<Courses> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
