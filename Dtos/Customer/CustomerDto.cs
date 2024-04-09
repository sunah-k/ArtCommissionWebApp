using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Customer
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public String Username { get; set; } = string.Empty;
        public String Email { get; set; } = string.Empty;
    }
}