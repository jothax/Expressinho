using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.ValueObjects;
using Expressinho.Domain.ValueObjects.Contracts;

namespace CreatePassagerCommand
{
    public class CreatePassagerCommand : ICommand
    {
        public CreatePassagerCommand(){}
        public CreatePassagerCommand
        (
            string name, 
            Email email, 
            string phone, 
            EGender gender, 
            byte[] password,
            byte[] salt, 
            DateTime birthdate
        )
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
            Password = password;
            Salt = salt;
            BirthDate = birthdate;            
        }

        public string? Name {get; private set;}

        public Email? Email {get; private set;}
        
        public string? Phone {get; private set;}

        public EGender Gender{get; private set;}
        
        public byte[]? Password{get; private set;}

        public byte[]? Salt{get; private set;}
        
        public DateTime BirthDate {get; private set;}

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}