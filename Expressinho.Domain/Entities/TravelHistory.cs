using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Entities
{
    public class TravelHistory : Entity, IAggregateRoot
    {
        public TravelHistory(Travel travel, Passager passager, Motorist motorist)
        {
            Travel = travel;
            Passager = passager;
            Motorist = motorist;
        }
        public Travel Travel{get; private set;}
        public Passager Passager{get; private set;}
        public Motorist Motorist{get; private set;}
    }
}