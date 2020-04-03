using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class CarStoreContext : DbContext
    {
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
    }
}