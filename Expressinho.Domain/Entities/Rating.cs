using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Entities
{
    public class Rating : Entity, IAggregateRoot
    {
        public Rating(decimal rate, Guid idEntity)
        {
            Date = DateTime.Now;
            Rate = rate;
            IdEntity = idEntity;
        }
        public DateTime Date{get; private set;}
        public decimal Rate{get; private set;}
        public Guid IdEntity{get; private set;}
    }
}