using Expressinho.Domain.Commands.Contracts;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateAddressCommand : Contract<CreateAddressCommand>, ICommand
    {
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
        
        public string Number {get; private set;}
        public string Street {get; private set;}
        public string City {get; private set;}
        public string State {get; private set;}
        public string Zipcode {get; private set;}
        public Guid IdEntity{get; private set;}

        public void Validate()
        {
            AddNotifications
            (
                Requires()
                .IsNotNullOrEmpty(Number,$"Não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Street,"Não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(City, "Não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(State,"Não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Zipcode,"Não pode ser nulo ou vazio")
            );
        }
    }
}