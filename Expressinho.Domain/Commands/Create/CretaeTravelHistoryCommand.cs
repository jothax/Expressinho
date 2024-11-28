using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CretaeTravelHistoryCommand : Contract<CretaeTravelHistoryCommand> ,ICommand
    {
        public CretaeTravelHistoryCommand(Travel travel, Motorist motorist, Passager passager)
        {
            Travel = travel;
            Motorist = motorist;
            Passager = passager;
        }
        public Travel Travel{get; private set;}
        public Motorist Motorist{get; private set;}
        public Passager Passager{get; private set;}

        public void Validate()
        {
            AddNotifications
            (
                Requires()
                .IsNotNull(Travel,"Não pode ser nulo")
                .IsNotNull(Motorist,"Não pode ser nulo")
                .IsNotNull(Passager,"Não pode ser nulo")
            );
            
        }
    }
}