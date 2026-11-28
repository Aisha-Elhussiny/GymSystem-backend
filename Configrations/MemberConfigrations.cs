using GymSystem_backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem_backend.Configrations
{
    public class MemberConfigurations : GymUserConfigurations<Member> , IEntityTypeConfiguration<Member>
    {
        public void configure (EntityTypeBuilder<Member> builder)
        {


            builder.Property(x => x.CreatedAt)
                .HasColumnName("JoinDate")
                .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }

    }
}
