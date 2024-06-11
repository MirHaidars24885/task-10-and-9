using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task10.Entities;

namespace Task10.Configs;

public class PatientConfiguration :IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> modelBuilder)
    {
        modelBuilder
            .HasKey(p => p.IdPatient);
        modelBuilder
            .Property(p => p.IdPatient)
            .ValueGeneratedOnAdd()
            .IsRequired();
        modelBuilder
            .Property(p => p.FirstName)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder
            .Property(p => p.LastName)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder
            .Property(p => p.BirthDate)
            .IsRequired();
        modelBuilder
            .ToTable("Patient");
    }
}