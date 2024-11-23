using Expressinho.Domain.ValueObjects.Contracts;

namespace Expressinho.Domain.ValueObjects
{
    public class Licence : ValueObjects
    {
        public Licence(string registeNumber, string licenceNumber)
        {
            RegisterNumber = registeNumber;
            LicenceNumber = licenceNumber;

            AddNotifications(new CreateLicenceContract(this)); 
        }
        public string RegisterNumber{get; private set;}
        public string LicenceNumber{get; private set;}
    }
}