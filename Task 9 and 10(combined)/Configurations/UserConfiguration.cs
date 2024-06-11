using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task10.Entities;

namespace Task10.Configs;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.IdUser);
        builder.Property(u => u.IdUser).IsRequired();
        builder.Property(u => u.Login).HasMaxLength(100).IsRequired();
        builder.Property(u => u.Password).HasMaxLength(100).IsRequired();
        builder.Property(u => u.RefreshToken).HasMaxLength(200);
        builder.Property(u => u.Salt).HasMaxLength(200);
        builder.Property(u => u.RefreshTokenExp);
        builder.ToTable("User");
    }
}