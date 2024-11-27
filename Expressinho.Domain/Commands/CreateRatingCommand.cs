using Expressinho.Domain.Commands.Contracts;

namespace Expressinho.Domain.Commands
{
    public class CreateRatingCommand : ICommand
    {
        public CreateRatingCommand(){}
        public CreateRatingCommand(decimal rate, Guid idEntity)
        {
            Date = DateTime.Now;
            Rate = rate;
            IdEntity = idEntity;
        }
        public DateTime Date{get; private set;}
        public decimal Rate{get; private set;}
        public Guid IdEntity{get; private set;}

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}