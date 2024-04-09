using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class ReferenceImage
    {
        public int Id { get; set; } 
        public String Description { get; set; } = string.Empty;
        public String ImageFilePath { get; set; } = string.Empty;
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}