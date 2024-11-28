using Expressinho.Domain.Entities;
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Repositories
{
    public interface IPassagerRepository : IRepository<Passager>
    {
        void GetPassagerByEmail(Email email);
        void GetPassagerById(Guid id);
    }
}