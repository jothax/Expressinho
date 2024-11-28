using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface ITravelRepository : IRepository<Travel>
    {
        void GetTravelById(Guid id);
    }
}