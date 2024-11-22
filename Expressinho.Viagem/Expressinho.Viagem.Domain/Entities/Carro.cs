namespace Expressinho.Viagem.Domain.Entities
{
    public class Carro : Entity
    {
        public Carro(Guid id, string modelo, string placa)
        {
            Id = id;
            Modelo = modelo;
            Placa = placa;
        }
        
        public string Modelo{get; private set;}
        public string Placa{get; private set;}
    }
}