using CarDealershipAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPI.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
