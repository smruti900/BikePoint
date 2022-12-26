using BikePoint.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikePoint.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<BikeNews> BikeNews { get; set; }
        public DbSet<BikeBrand> BikeBrand { get; set; }
        public DbSet<BikeList> BikeList { get; set; }
    }
}
