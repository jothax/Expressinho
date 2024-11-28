using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<Address> GetEntityAddreesById(Guid id);
    }
}