namespace Expressinho.Domain.Entities
{
    public class Address : Entity
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
            IdEntity = idEntity;
        }
        public string Number {get; private set;}
        public string Street {get; private set;}
        public string City {get; private set;}
        public string State {get; private set;}
        public string Zipcode {get; private set;}
        public Guid IdEntity{get; private set;}
    }
}
