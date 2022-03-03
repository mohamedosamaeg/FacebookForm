using facebook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace facebook
{
    public class FacebookDbContext :DbContext
    {
        public const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FacebookDb;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Stories> Story { get; set; }
        public DbSet<Groups> Group { get; set; }
        public DbSet<MainOptions> Settings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DateTime CreatedDate { get; internal set; }
        public object Groups { get; internal set; }
        public object User { get; internal set; }
        public object UserRole { get; internal set; }
    }
}
