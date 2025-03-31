using APIORACLE.Entities;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;

namespace APIORACLE.Data
{
    public class OracleDbContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Alumno> Alumno { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración para indicar que Alumno no tiene clave primaria
            modelBuilder.Entity<Alumno>().HasNoKey();
            modelBuilder.Entity<Grupos>().HasNoKey();
            modelBuilder.Entity<Alumnos>()
           .HasKey(a => a.id_alumno);

            base.OnModelCreating(modelBuilder);
        }

    }
}
