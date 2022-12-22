using Sinema.Entities.Entities.Abstract;

namespace Sinema.Entities.Entities.Concrete
{
    public class Salon : BaseEntity<Guid>
    {
        public string SalonAdi { get; set; }
        public byte? Kapasite { get; set; } = 0;

        public ICollection<Gosterim> Gosterimler { get; set; }

    }
}