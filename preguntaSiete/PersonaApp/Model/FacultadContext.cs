using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FacultadContext : DbContext
    {
        public FacultadContext(DbContextOptions<FacultadContext> options)
        : base(options)
        {

        }

        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscripcion>().ToTable("Inscripcion");
            modelBuilder.Entity<Persona>().ToTable("Persona");
        }

    }

}
