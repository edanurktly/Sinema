using Sinema.Entities.Entities.Abstract;

namespace Sinema.Entities.Entities.Concrete
{
    public class Gosterim : BaseEntity<Guid>
    {
        public Guid? FilmId { get; set; } // Database'e burasi yansir

        public Film? Film { get; set; } // Burasi db'ye yansimaz. Bu prop NAvigation Property'sidir

        public Guid? SalonId { get; set; }
        public Salon? Salon { get; set; }

        public Guid? HaftaId { get; set; }
        public Hafta? Haftalar { get; set; }

        public Guid? SeansId { get; set; }
        public Seans? Seanlar { get; set; }





    }
}