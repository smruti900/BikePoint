using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Models
{
    public class BikeBrand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Logo { get; set; }
        public List<BikeList> BikeLists { get; set; } = new List<BikeList>();
    }
}
