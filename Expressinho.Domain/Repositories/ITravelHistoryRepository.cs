using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface ITravelHistoryRepository : IRepository<TravelHistory>
    {
        void GetTravelById(Guid id);
        void GetMotoristById(Guid id);
        void GetPassagerById(Guid id);
    }
}