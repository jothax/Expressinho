
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Trip : Entity
    {
        public Trip
        (
            Coordinate origin, 
            Coordinate destiny,
            DateTime startDate,
            DateTime finishDate, 
            decimal value, 
            decimal userRating, 
            decimal driverRating,
            EPaymentMethod paymentMethod,
            ETripMethod tripMethod 
        ) 
            : base()
        {
            Origin = origin;
            Destiny = destiny;
            Value = value;
            UserRating = userRating;
            DriverRating = driverRating;
            PaymentMethod = paymentMethod;
            TripMethod = tripMethod;
            StartDate = startDate;
            
            //metodo para aceitar um finish depois
            FinishDate = finishDate;
        }
        public Coordinate Origin {get; private set;}
        
        public Coordinate Destiny{get; private set;}
        
        public DateTime StartDate{get; private set;}
        
        public DateTime FinishDate{get; private set;}
        
        public decimal Value {get; private set;}
        
        public decimal UserRating{get; private set;}
        
        public decimal DriverRating{get; private set;}

        public EPaymentMethod PaymentMethod {get; private set;}
        
        public ETripMethod TripMethod {get; private set;}
    }
}