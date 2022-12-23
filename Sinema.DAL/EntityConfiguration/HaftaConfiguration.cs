using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinema.Entities.Entities.Concrete;

namespace Sinema.DAL.EntityConfiguration
{
    public class HaftaConfiguration : BaseEntityConfiguration<Hafta>
    {
        public override void Configure(EntityTypeBuilder<Hafta> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.HaftaAdi).HasMaxLength(50);
            builder.Property(p => p.Baslangic)
                  .IsRequired(false);
            builder.Property(p => p.Bitis)
                 .IsRequired(false);

        }
    }
}
