using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinema.Entities.Entities.Concrete;

namespace Sinema.DAL.EntityConfiguration
{
    public class SalonConfiguration : BaseEntityConfiguration<Salon>
    {
        public override void Configure(EntityTypeBuilder<Salon> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SalonAdi)
                 .HasMaxLength(50);
        }
    }
}
