using facebook.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace facebook
{
    public class FacebookDbContext :DbContext
    {
        public const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FacebookDb;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Stories>Story { get; set; }
        public DbSet<Address> Addresses { get; set; }
        
        public DateTime CreatedDate { get;  set; }
        public DbSet<Groups> groups { get;  set; }
        public DbSet<User> users{ get; set; }
        public DbSet<UserRole> UserRole { get;  set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Warning> Warning { get; set; }

    }
}
