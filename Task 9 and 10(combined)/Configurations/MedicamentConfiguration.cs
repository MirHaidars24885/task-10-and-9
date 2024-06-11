using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task10.Entities;

namespace Task10.Configs;

public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> modelBuilder)
    {
        modelBuilder
            .HasKey(m => m.IdMedicament);
        modelBuilder
            .Property(m => m.IdMedicament)
            .ValueGeneratedOnAdd()
            .IsRequired();
        modelBuilder
            .Property(m => m.Name)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder
            .Property(m => m.Description)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder
            .Property(m => m.Type)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder
            .ToTable("Medicament");
    }
}