using Sinema.Entities.Entities.Abstract;

namespace Sinema.Entities.Entities.Concrete
{
    public class Hafta : BaseEntity<Guid>
    {
        public string HaftaAdi { get; set; }
        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }

        public ICollection<Gosterim> Gosterimler { get; set; }

    }
}