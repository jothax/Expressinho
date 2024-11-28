using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Repositories
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        void Create( T entity);
        void Update(T entity);
    }
}