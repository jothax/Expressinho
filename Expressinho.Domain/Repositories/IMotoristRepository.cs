using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface IMotoristRepository : IRepository<Motorist>
    {
        void GetMotoristById(Guid id);
    }
}