using Sinema.Entities.Entities.Abstract;

namespace Sinema.Entities.Entities.Concrete
{
    public class Seans : BaseEntity<Guid>
    {
        public String SeansAdi { get; set; }

        public ICollection<Gosterim> Gosterimler { get; set; }

    }
}
