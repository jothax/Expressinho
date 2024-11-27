using System.Data.Common;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Repositories;

namespace Expressinho.Tests.Repositories
{
    public class FakeCarRepository : ICarRepository
    {
        public void Create(Car car)
        {
        }
        public IEnumerable<Car> Get()
        {
            IEnumerable<Car> cars = [];
            
            return cars;
        }

        /*  public IEnumerable<Car> GetByMotoistId(Guid id)
         {

         } */

        public void Update(Car car)
        {
           
        }
    }
}