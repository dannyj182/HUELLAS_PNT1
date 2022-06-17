using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUELLAS_PNT1.Models;

namespace HUELLAS_PNT1.Context
{
    public class HuellasDatabaseContext : DbContext
    {
        public HuellasDatabaseContext()
        {
        }

        public
       HuellasDatabaseContext(DbContextOptions<HuellasDatabaseContext> options)
       : base(options)
        {
        }
        public DbSet<Mascota> Pets { get; set; }
        public DbSet<Interesado> Adopters { get; set; }
    }
}

