using Microsoft.EntityFrameworkCore;
using MiMicroservicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMicroservicio.Infrastructure.Persistence
{
    public class MiMicroservicioDbContext : DbContext
    {
        public MiMicroservicioDbContext(DbContextOptions<MiMicroservicioDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales si son necesarias
        }
    }
}
