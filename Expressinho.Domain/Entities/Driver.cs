
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Driver : User
    {
        public Driver(
            Licence licence,
            ELicenceCategory licenceCategory,    
            Name name, 
            Email email, 
            string phone, 
            EGender gender, 
            byte[] password,
            byte[] salt, 
            DateTime birthdate
        )
        : base(
                name, 
                email, 
                phone, 
                gender, 
                password,
                salt, 
                birthdate
            )
        {
            Licence = licence;
            LicenceCategory = licenceCategory;
        }

        public Licence Licence{get; private set;}

        public ELicenceCategory LicenceCategory{get; private set;}        
    }
}