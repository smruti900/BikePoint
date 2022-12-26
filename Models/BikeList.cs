using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Models
{
    public class BikeList
    {
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public string BikeModelName { get; set; }
        public string Color { get; set; }
        public decimal BikePrice { get; set; }
        public string Mileage { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public virtual BikeBrand BikeBrand { get; set; }
    }
}
