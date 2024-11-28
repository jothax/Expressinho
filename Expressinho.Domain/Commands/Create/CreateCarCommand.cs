using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateCarCommand : Contract<CreateCarCommand>, ICommand
    {
        public CreateCarCommand(string model, string year, string plate, Motorist motorist)
        {
            Model = model;
            Year = year;
            Plate = plate;
            Motorist = motorist;
        }

        public string Model {get; private set;}
        public string Year {get; private set;}
        public string Plate {get; private set;}
        public Motorist Motorist{get; private set;}

        public void Validate()
        {
           AddNotifications(
            Requires()
            .IsNotNullOrEmpty(Model,"Não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(Year,"Não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(Plate,"Não pode ser nulo ou vazio")
           );   
        }
    }
}