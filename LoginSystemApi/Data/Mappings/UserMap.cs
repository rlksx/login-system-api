using LoginSystemApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoginSystemApi.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        /* configurando tabela user */
        builder.ToTable("User");
        builder.HasKey(x => x.Id);

        /* id config */
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        /* name config */
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        /* email config */
        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnName("Email")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(160);

        /* password config */
        builder.Property(x => x.PasswordHash)
            .IsRequired()
            .HasColumnName("PasswordHash")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(255);
        
        /* index config */
        builder.HasIndex(x => x.Id)
            .IsUnique();
    }
}