using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface ICarRepository
    {
        void Create(Car car);
        void Update(Car car);
        IEnumerable<Car> Get();
        //IEnumerable<Car> GetByMotoistId(Guid id);
    }
}