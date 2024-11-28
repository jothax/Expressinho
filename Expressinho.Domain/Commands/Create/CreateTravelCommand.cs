using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
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
            decimal userRating, 
            decimal driverRating,
            EPaymentMethod paymentMethod,
            ETripMethod tripMethod,
            Motorist motorist,
            Passager passager 
        )
        {
            Origin = origin;
            Destiny = destiny;
            Price = price;
            UserRating = userRating;
            DriverRating = driverRating;
            PaymentMethod = paymentMethod;
            TripMethod = tripMethod;
            Motorist = motorist;
            Passager = passager;
            StartDate = startDate;
            FinishDate = finishDate;            
        }
        public Coordinate Origin {get; private set;}
        public Coordinate Destiny{get; private set;}
        public DateTime StartDate{get; private set;}
        public DateTime FinishDate{get; private set;}
        public decimal Price {get; private set;}
        public decimal UserRating{get; private set;}
        public decimal DriverRating{get; private set;}
        public EPaymentMethod PaymentMethod {get; private set;}
        public ETripMethod TripMethod {get; private set;}
        public Motorist Motorist {get; private set;}
        public Passager Passager {get; private set;}

        public void Validate()
        { 
            AddNotifications
            (
                Requires()
                .IsGreaterThan(Price, 0m,"Tem que ser maior que 0")
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