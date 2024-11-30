using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Enums;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateCarCommand : Contract<CreateCarCommand>, ICommand
    {
        public CreateCarCommand(EModel model, string year, string plate, Guid motorist)
        {
            Model = model;
            Year = year;
            Plate = plate;
            Motorist = motorist;
        }

        public EModel Model {get; set;}
        public string Year {get; set;}
        public string Plate {get; set;}
        public Guid Motorist{get; set;}

        public void Validate()
        {
           AddNotifications(
            Requires()
            .IsNotNullOrEmpty(Year,"Não pode ser nulo ou vazio")
            .IsNotNullOrEmpty(Plate,"Não pode ser nulo ou vazio")
           );   
        }
    }
}