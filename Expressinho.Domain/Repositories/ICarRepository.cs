using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface ICarRepository : IRepository<Car>
    {
        IEnumerable<Car> GetByMotoistId(Guid id);
    }
}