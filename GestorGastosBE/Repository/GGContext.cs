using GestorGastosBE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorGastosBE.Repository
{
    public class GGContext :DbContext
    {
        public GGContext(DbContextOptions<GGContext> options) : base(options)
        {
        }

        public DbSet<CategoriaGasto> CategoriasGastos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaGasto>().ToTable("CategoriaGasto");
        }

    }

}
