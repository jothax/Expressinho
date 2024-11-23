using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.ValueObjects;

namespace CreateTripCommand
{
    public class CreateTripCommand : ICommand
    {
        public CreateTripCommand()
        {
            
        }
        public Coordinate Origin {get; private set;}
        
        public Coordinate Destiny{get; private set;}
        
        public DateTime StartDate{get; private set;}
        
        public DateTime FinishDate{get; private set;}
        
        public decimal TripValue {get; private set;}
        
        public decimal UserRating{get; private set;}
        
        public decimal DriverRating{get; private set;}

        public EPaymentMethod PaymentMethod {get; private set;}
        
        public ETripMethod TripMethod {get; private set;}
        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}