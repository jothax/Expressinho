using Expressinho.Domain.Entities.Contracts;
using Expressinho.Domain.ValueObjects;

namespace Expressinho.Domain.Entities
{
    public class Passager: Entity, IAggregateRoot
    {
        public Passager(
        string name, 
        Email email, 
        byte[] password,
        byte[] salt,
        int iterations, 
        DateTime birthdate
        ): base()
        {
            Name = name;
            Email = email;
            Password = password;
            Salt = salt;
            Iterations = iterations;
            BirthDate = birthdate;
            Active = true;
        }
        public string Name {get; private set;}
        public Email Email {get; private set;}
        public byte[] Password{get; private set;}
        public byte[] Salt{get; private set;}
        public int Iterations {get; private set;}
        public DateTime BirthDate {get; private set;} 
        public bool Active{get; private set;}

        public void Desactive()
        {
            Active = false;
        }
    }
}