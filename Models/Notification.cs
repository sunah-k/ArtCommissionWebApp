using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public String Message { get; set; } = string.Empty;
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}