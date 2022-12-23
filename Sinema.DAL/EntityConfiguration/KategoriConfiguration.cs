using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinema.Entities.Entities.Concrete;

namespace Sinema.DAL.EntityConfiguration
{
    public class KategoriConfiguration : BaseEntityConfiguration<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.KategoriAdi).HasMaxLength(50);
            builder.Property(p => p.Aciklama).HasMaxLength(100);

            // Ayni Kategori isminden bir tane daha olmasin 
            builder.HasIndex(p => p.KategoriAdi).IsUnique();


        }
    }
}
