using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface IRatingRepository : IRepository<Rating>
    {
        void GetById(Guid id);
    }
}