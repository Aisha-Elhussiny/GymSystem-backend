using GymSystem_backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem_backend.Configrations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(X => X.Id);

            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
