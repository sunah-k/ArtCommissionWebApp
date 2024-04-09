using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }   
        public DbSet<Order> Orders { get; set;}   
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ReferenceImage> ReferenceImages { get; set; }
        
    }
}