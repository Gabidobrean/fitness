using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using fitness.Models;

namespace fitness.Data
{
    public class fitnessContext : DbContext
    {
        public fitnessContext (DbContextOptions<fitnessContext> options)
            : base(options)
        {
        }

        public DbSet<fitness.Models.Antrenor> Antrenor { get; set; }
    }
}
