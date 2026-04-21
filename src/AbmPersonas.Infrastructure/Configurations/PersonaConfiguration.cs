using AbmPersonas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbmPersonas.Infrastructure.Configurations;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Personas");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();

        builder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Apellido).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Documento).IsRequired().HasMaxLength(20);
        builder.HasIndex(x => x.Documento).IsUnique();

        builder.Property(x => x.FechaNacimiento).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(150);
        builder.Property(x => x.Telefono).HasMaxLength(30);

        builder.Property(x => x.Activo).IsRequired().HasDefaultValue(true);
        builder.Property(x => x.FechaAlta).IsRequired().HasDefaultValueSql("GETUTCDATE()");
    }
}
