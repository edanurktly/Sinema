using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinema.Entities.Entities.Concrete;

namespace Sinema.DAL.EntityConfiguration
{
    public class SeansConfiguration : BaseEntityConfiguration<Seans>
    {
        public override void Configure(EntityTypeBuilder<Seans> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SeansAdi)
               .HasMaxLength(50);
        }
    }
}
