
using System.Reflection.Metadata;
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Travel : Entity
    {
        public Travel
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
            : base()
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
    }
}