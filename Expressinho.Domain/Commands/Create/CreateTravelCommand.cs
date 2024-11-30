using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Enums;
using Expressinho.Domain.ValueObjects;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class CreateTravelCommand : Contract<CreateTravelCommand>, ICommand
    {
        public CreateTravelCommand
        (
            Coordinate origin, 
            Coordinate destiny,
            DateTime startDate,
            DateTime finishDate, 
            decimal price, 
            decimal passagerRating, 
            decimal motoristRating,
            EPaymentMethod paymentMethod,
            ETripMethod tripMethod,
            Guid idMotorist,
            Guid idPassager 
        )
        {
            Origin = origin;
            Destiny = destiny;
            StartDate = startDate;
            FinishDate = finishDate;
            Price = price;
            PassagerRating = passagerRating;
            MotoristRating = motoristRating;
            PaymentMethod = paymentMethod;
            TripMethod = tripMethod;
            IdMotorist = idMotorist;
            IdPassager = idPassager;            
        }
        public Coordinate Origin {get; set;}
        public Coordinate Destiny{get; set;}
        public DateTime StartDate{get; set;}
        public DateTime FinishDate{get; set;}
        public decimal Price {get; set;}
        public decimal PassagerRating{get; set;}
        public decimal MotoristRating{get; set;}
        public EPaymentMethod PaymentMethod {get; set;}
        public ETripMethod TripMethod {get; set;}
        public Guid IdMotorist {get; set;}
        public Guid IdPassager {get; set;}

        public void Validate()
        { 
            AddNotifications
            (
                Requires()
                .IsGreaterOrEqualsThan(Price, 0m,"Tem que ser maior ou igual a 0")
                .Join(Origin,Destiny)
            );
        }

        public decimal ReviseRate(decimal rating)
        {
            if(rating > 5m)
                return 5m;
            return rating;
        }
    }
}