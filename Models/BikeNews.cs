using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Models
{
    public class BikeNews
    {
        public int NewsId { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public DateTime updateddate { get; set; } = DateTime.Now;
        public string createduser { get; set; }
    }
}
