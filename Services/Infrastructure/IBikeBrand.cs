using BikePoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Services.Infrastructure
{
    public interface IBikeBrand
    {       
        BikeBrand GetBikeBrand(int BrandId);
        void Insert(BikeBrand bikeBrand);
        void Delete(int BrandId);
        void Update(BikeBrand bikeBrand);
    }
}
