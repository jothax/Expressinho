using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface IMotoristRepository
    {
        void Create(Motorist motorist);
        void Update(Motorist motorist);
        IEnumerable<Motorist> GetById(Guid id);
    }
}