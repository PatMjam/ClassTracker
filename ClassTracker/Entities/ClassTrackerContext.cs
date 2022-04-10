using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTracker.Entities
{
    public class ClassTrackerContext : DbContext 
    {
        public ClassTrackerContext(DbContextOptions options) : base(options)
        {
            // we create the constructor

        }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<TafeClass> TafeClasses { get; set; }

        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // this is the method used to configure
            builder.Entity<Teacher>().HasData(
                    new Teacher { TeacherId = 1, TeacherName = "Melissa", TeacherEmail = "mhour25@eq.edu.au", TeacherPhone = "0410541265" },
                    new Teacher { TeacherId = 2, TeacherName = "Erick", TeacherEmail = "ekala1@eq.edu.au", TeacherPhone = "0415752145"}
                );
        }
    }
}
