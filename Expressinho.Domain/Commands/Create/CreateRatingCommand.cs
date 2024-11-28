using Expressinho.Domain.Commands.Contracts;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateRatingCommand : Contract<CreateRatingCommand>, ICommand
    {
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
            AddNotifications
            (
                Requires()
                .IsBetween(Rate,0m, 5.1m,"Tem que estar entre 0 e 5")
            );
        }
    }
}