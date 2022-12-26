using BikePoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Services.Infrastructure
{
   public interface IBikeNews
    {
        IEnumerable<BikeNews> GetBikeNews();
        BikeNews GetBikeNews(int NewsId);
        void Insert(BikeNews bikenews);
        void Delete(int NewsId);
        void Update(BikeNews bikenews);
    }
}
