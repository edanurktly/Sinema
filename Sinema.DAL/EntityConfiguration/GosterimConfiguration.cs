using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinema.Entities.Entities.Concrete;

namespace Sinema.DAL.EntityConfiguration
{
    public class GosterimConfiguration : BaseEntityConfiguration<Gosterim>
    {
        public override void Configure(EntityTypeBuilder<Gosterim> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => new { p.HaftaId, p.SalonId, p.FilmId, p.SeansId }).IsUnique();

        }
    }
}
