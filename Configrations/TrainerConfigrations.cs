using GymSystem_backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem_backend.Configrations
{
    public class TrainerConfigurations :GymUserConfigurations<Trainer>  ,IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(x => x.CreatedAt)
                .HasColumnName("HiringDate")
                .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
