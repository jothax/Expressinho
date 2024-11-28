using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Entities
{
    public class Address : Entity, IAggregateRoot
    {
        public Address(
            string number, 
            string street, 
            string city, 
            string state, 
            string zipcode, 
            Guid idEntity
            ) : base()
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
            Entity = idEntity;
        }
        public string Number {get; private set;}
        public string Street {get; private set;}
        public string City {get; private set;}
        public string State {get; private set;}
        public string Zipcode {get; private set;}
        public Guid Entity {get; private set;}
    }
}
