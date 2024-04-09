using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public DateTime OrderedOn { get; set; }
        public DateTime DeliverOn { get; set; }
        public String Status { get; set; } = string.Empty;
        public String CommissionType { get; set; } = string.Empty;
        public int NumCharacters { get; set; } 
        public int NumElements { get; set; }
        public String BackgroundType { get; set; } = string.Empty;
        public String Description { get; set; } = string.Empty;
        public List<ReferenceImage> ReferenceImages { get; set; } = new List<ReferenceImage>();
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}