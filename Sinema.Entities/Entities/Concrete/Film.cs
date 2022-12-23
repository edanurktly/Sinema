using Sinema.Entities.Entities.Abstract;

namespace Sinema.Entities.Entities.Concrete
{
    public class Film : BaseEntity
    {
        public string FilmAdi { get; set; }
        public string? Aciklama { get; set; }
        public short? FilmSuresi { get; set; }

        public ICollection<Kategori>? Kategoriler { get; set; }

        public ICollection<Gosterim>? Gosterimleri { get; set; }

    }
}