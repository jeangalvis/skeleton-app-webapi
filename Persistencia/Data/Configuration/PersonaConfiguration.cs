using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.HasKey(e => e.IdPersona);
            builder.Property(e => e.IdPersona)
            .HasMaxLength(20);

            builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdGeneroFk);

            
        }
    }
}