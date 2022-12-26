using BikePoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Services.Infrastructure
{
    public interface IBikeList
    {
        IEnumerable<BikeList> GetBikeLists();
        BikeList GetBike(int BikeName);
        void Insert(BikeList bikes);
        void Delete(int BikeId);
        void Update(BikeList bikes);
    }
}
