using Expressinho.Domain.Entities.Contracts;

namespace Expressinho.Domain.Entities
{
    public class Address : Entity
    {
        public Address(string number, string street, string city, string state, string zipcode) : base()
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
            
            AddNotifications(new CreateAddressContract(this));
        }
        public string Number {get; private set;}
        public string Street {get; private set;}
        public string City {get; private set;}
        public string State {get; private set;}
        public string Zipcode {get; private set;}
    }
}
