using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocationOfToys.Models;

namespace LocationOfToys.Data
{
    public class LocationOfToysContext : DbContext
    {
        public LocationOfToysContext (DbContextOptions<LocationOfToysContext> options)
            : base(options)
        {
        }

        public DbSet<LocationOfToys.Models.Box> Box { get; set; }
    }
}
