using Entidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Datos.Contexts
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CuentaBancaria> CuentaBancarias { get; set; }
        public virtual DbSet<TarjetaCredito> TarjetaCredito { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AppBancaria;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(k => k.ID).HasName("PK_ID_CLIENTE");
                entity.HasMany(c => c.Cuentas).WithOne(c => c.Cliente).HasForeignKey("FK_ID_CLIENTE");
                entity.HasMany(t => t.TarjetasCredito).WithOne(c => c.Cliente).HasForeignKey("FK_ID_CLIENTE");
            });

            modelBuilder.Entity<CuentaBancaria>(entity =>
            {
                entity.HasKey(k => k.ID).HasName("PK_ID_CUENTABANCARIA");
            });

            modelBuilder.Entity<TarjetaCredito>(entity =>
            {
                entity.HasKey(k => k.ID).HasName("PK_ID_TARJETACREDITO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
