using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserManagementWebApp.Models
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext (DbContextOptions<UserManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserManagementWebApp.Models.User> User { get; set; }
    }
}
