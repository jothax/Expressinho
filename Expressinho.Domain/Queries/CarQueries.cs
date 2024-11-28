using System.Linq.Expressions;
using Expressinho.Domain.Entities;

namespace Expressinho.Domain.Queries
{
    public static class CarQueries
    {
        public static Expression<Func<Car, bool>> GetByMotoristId(Guid id)
        {
            return x => x.Motorist.Id == id;
        }
    }
}