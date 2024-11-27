using Expressinho.Domain.Commands.Contracts;

namespace Expressinho.Domain.Commands
{
    public class CretaeTravelHistoryCommand : ICommand
    {
        public CretaeTravelHistoryCommand(){}

        public CretaeTravelHistoryCommand(Guid idTravel, Guid idPassager, Guid idMotorist)
        {
            IdTravel = idTravel;
            IdPassager = idPassager;
            IdMotorist = idMotorist;
        }
        public Guid IdTravel{get; private set;}
        public Guid IdPassager{get; private set;}
        public Guid IdMotorist{get; private set;}

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}