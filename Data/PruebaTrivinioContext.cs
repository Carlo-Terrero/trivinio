using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
// using MvcMovie.Models;
using PruebaTrivinio.Models;

namespace PruebaTrivinio.Data
{
    public class PruebaTrivinioContext : DbContext
    {
        public PruebaTrivinioContext (DbContextOptions<PruebaTrivinioContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaTrivinio.Models.Cliente> Cliente { get; set; } = default!;
    }
}
