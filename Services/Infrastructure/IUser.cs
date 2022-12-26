using BikePoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Services.Infrastructure
{
    interface IUser
    {
        void Insert(User user);
        void Delete(int UserId);
        void Update(User user);
    }
}
