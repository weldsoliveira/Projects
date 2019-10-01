using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Model
{
    public partial class GranadoFluxoContext : DbContext
    {
        public GranadoFluxoContext()
        {
        }

        public GranadoFluxoContext(DbContextOptions<GranadoFluxoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=vmdb1;initial catalog=GranadoFluxo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Descricao).HasMaxLength(50);

                entity.Property(e => e.Nome).HasMaxLength(50);
            });
        }
    }
}
