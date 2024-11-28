
using Expressinho.Domain.Entities.Contracts;
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Motorist : Entity, IAggregateRoot
    {
        public Motorist(    
            string name, 
            Email email, 
            string phone, 
            EGender gender, 
            byte[] password,
            byte[] salt,
            int iterations, 
            DateTime birthdate,
            Licence licence,
            ELicenceCategory licenceCategory
        ): base()
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
            Password = password;
            Salt = salt;
            Iterations = iterations;
            BirthDate = birthdate;
            Licence = licence;
            LicenceCategory = licenceCategory;
        }
        public string Name {get; private set;}

        public Email Email {get; private set;}
        
        public string Phone {get; private set;}

        public EGender Gender{get; private set;}
        
        public byte[] Password{get; private set;}

        public byte[] Salt{get; private set;}

        public int Iterations {get; private set;}
        public DateTime BirthDate {get; private set;}

        public Licence Licence{get; private set;}

        public ELicenceCategory LicenceCategory{get; private set;}        
    }
}