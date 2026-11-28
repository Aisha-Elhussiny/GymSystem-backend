using GymSystem_backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymSystem_backend.Configrations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(x => x.Phone)
             .HasColumnType("varchar")
             .HasMaxLength(11);

            builder.ComplexProperty(x => x.Address);
     
           builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_Phone_Check", "LEN(Phone) = 11 AND (Phone Like '010%' OR Phone Like '011%' OR Phone Like '012%' OR Phone Like '015%')");
                T.HasCheckConstraint("GymUser_Email_Check", "Email Like '__%@__%.__%'");

            });

        }
    }
}
