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
        public DateTime Date{get; set;}
        public decimal Rate{get; set;}
        public Guid IdEntity{get; set;}

        public void Validate()
        {
            AddNotifications
            (
                Requires()
                .IsBetween(Rate,0m, 5m,"Tem que estar entre 0 e 5")
            );
        }
    }
}