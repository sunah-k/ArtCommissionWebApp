using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String Username { get; set; } = string.Empty;
        public String Email { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Notification> Notifications { get; set; } = new List<Notification>();
    }
}