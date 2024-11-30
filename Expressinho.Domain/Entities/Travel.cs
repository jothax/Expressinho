using Expressinho.Domain.Entities.Contracts;
using Expressinho.Domain.Enums;
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Travel : Entity, IAggregateRoot
    {
        public Travel
        (
            Coordinate origin, 
            Coordinate destiny,
            DateTime startDate,
            DateTime finishDate, 
            decimal price, 
            EPaymentMethod paymentMethod,
            ETripMethod tripMethod,
            Guid idMotorist,
            Guid idPassager 
        ) 
            : base()
        {
            Origin = origin;
            Destiny = destiny;
            Price = price;
            PaymentMethod = paymentMethod;
            TripMethod = tripMethod;
            IdMotorist = idMotorist;
            IdPassager = idPassager;
            StartDate = startDate;
            FinishDate = finishDate;

        }
        public Coordinate Origin {get; private set;}
        public Coordinate Destiny{get; private set;}
        public DateTime StartDate{get; private set;}
        public DateTime FinishDate{get; private set;}
        public decimal Price {get; private set;}
        public EPaymentMethod PaymentMethod {get; private set;}
        public ETripMethod TripMethod {get; private set;}
        public Guid IdMotorist {get; private set;}
        public Guid IdPassager {get; private set;}
    }
}