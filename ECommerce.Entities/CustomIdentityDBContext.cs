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
        public CustomIdentityDBContext(DbContextOptions<CustomIdentityDBContext> options)
            : base(options)
        {
        }
        public DbSet<CustomIdentityUser> Users { get; set; }
    }

}
