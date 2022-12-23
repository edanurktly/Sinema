using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinema.Entities.Entities.Concrete;

namespace Sinema.DAL.EntityConfiguration
{
    public class FilmConfiguration : BaseEntityConfiguration<Film>
    {
        public override void Configure(EntityTypeBuilder<Film> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.FilmAdi).HasMaxLength(100);
            builder.Property(p => p.Aciklama).HasMaxLength(500);

        }
    }
}
