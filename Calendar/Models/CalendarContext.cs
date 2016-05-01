using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Calendar.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext() : base("SQLConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public DbSet<Available> Availables { get; set; }

    }
}