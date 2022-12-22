using Sinema.Entities.Entities.Abstract;

namespace Sinema.Entities.Entities.Concrete
{
    public class Kategori : BaseEntity<Guid>
    {
        public string KategoriAdi { get; set; }

        public string? Aciklama { get; set; }

        public ICollection<Film>? Filmler { get; set; }
    }
}