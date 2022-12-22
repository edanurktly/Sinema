using Sinema.DAL.Abstract;

namespace Sinema.DAL.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity, new()
    {

    }
}
