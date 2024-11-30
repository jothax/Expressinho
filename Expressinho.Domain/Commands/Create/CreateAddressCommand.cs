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
        
        public string Number {get; set;}
        public string Street {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public string Zipcode {get; set;}
        public Guid IdEntity{get; set;}

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