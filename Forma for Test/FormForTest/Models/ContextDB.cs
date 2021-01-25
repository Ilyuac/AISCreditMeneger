using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FormForTest.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Logbook> Logbooks { get; set; }

        public ContextDB()
        {
            Database.EnsureCreated();
        }
    }
}
