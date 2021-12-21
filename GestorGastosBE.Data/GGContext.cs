using GestorGastosBE.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestorGastosBE
{
    public class GGContext : DbContext
    {
        public GGContext(DbContextOptions<GGContext> options) : base(options)
        {
        }

        public DbSet<CategoriaGasto> CategoriasGastos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Medio> Medios { get; set; }
        public DbSet<SubcategoriaGasto> SubcategoriasGasto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaGasto>().ToTable("CategoriaGasto");
            modelBuilder.Entity<Gasto>().ToTable("Gasto");
            modelBuilder.Entity<Medio>().ToTable("Medio");
            modelBuilder.Entity<SubcategoriaGasto>().ToTable("SubcategoriaGasto");
        }

    }

}