using Expressinho.Domain.Entities;
using Expressinho.Domain.ValueObjects.Contracts;

namespace Expressinho.Domain.ValueObjects
{
    public class Value : ValueObjects
    {
        public Value(decimal distance, EQuantityBag quantityBag )
        {
            Distance = distance;
            QuantityBag = quantityBag ;

            //AddNotifications(new CreateValueContract(this));
        }

        public decimal Distance{get; private set;}
        public decimal Time {get; private set;}
        public EQuantityBag QuantityBag {get; private set;}

        public decimal Total()
        {
            return (Distance * (2.70m + )) + (decimal) QuantityBag;
        }
    }
}