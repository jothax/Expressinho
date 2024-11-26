using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Passager: Entity
    {
        public Passager(
        string name, 
        Email email, 
        string phone, 
        EGender gender, 
        byte[] password,
        byte[] salt, 
        DateTime birthdate
        ): base()
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
            Password = password;
            Salt = salt;
            BirthDate = birthdate;
        }
        public string Name {get; private set;}

        public Email Email {get; private set;}
        
        public string Phone {get; private set;}

        public EGender Gender{get; private set;}
        
        public byte[] Password{get; private set;}

        public byte[] Salt{get; private set;}
        
        public DateTime BirthDate {get; private set;}
 
    }
}