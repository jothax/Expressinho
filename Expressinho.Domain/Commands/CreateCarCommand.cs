using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateCarCommand : Contract<CreateCarCommand>, ICommand
    {
        public CreateCarCommand(){}

        public CreateCarCommand(string model, string year, string plate, Guid idMotorist)
        {
            Model = model;
            Year = year;
            Plate = plate;
            IdMotorist = idMotorist;
        }

        public string? Model {get; private set;}
        
        public string? Year {get; private set;}
        
        public string? Plate {get; private set;}
        public Guid IdMotorist{get; private set;}

        public void Validate()
        {
           AddNotifications(
            Requires()
            .IsNotNullOrEmpty(Model,"Modelo não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(Year,"Ano não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(Plate,"Placa não pode ser nulo ou vazio")
           );   
        }
    }
}