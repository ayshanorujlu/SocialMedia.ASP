using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Entities
{
    public class CustomIdentityDBContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {
        public CustomIdentityDBContext()
        {
        }

        public CustomIdentityDBContext(DbContextOptions<CustomIdentityDBContext> options)
           : base(options)
        {

        }

        public DbSet<Post>? Posts { get; set; }
        public DbSet<Friend>? Friends { get; set; }
        public DbSet<FriendRequest>? FriendRequests { get; set; }
        // Other DbSet properties...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Friend>().HasKey(f => f.Id); // Define 'Id' as primary key for Friend entity
            // Other configurations...
        }
    }

}
