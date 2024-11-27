using Expressinho.Domain.Commands.Contracts;

namespace CreateAddressCommand
{
    public class CreateAddressCommand : ICommand
    {
        public CreateAddressCommand(){}
        public CreateAddressCommand
        (
            string number, 
            string street, 
            string city, 
            string state, 
            string zipcode, 
            Guid idEntity
        )
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
            IdEntity = idEntity;            
        }
        
        public string? Number {get; private set;}
        public string? Street {get; private set;}
        public string? City {get; private set;}
        public string? State {get; private set;}
        public string? Zipcode {get; private set;}
        public Guid IdEntity{get; private set;}

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}