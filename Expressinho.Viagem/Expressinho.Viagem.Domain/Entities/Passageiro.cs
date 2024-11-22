namespace Expressinho.Viagem.Domain.Entities
{
    public class Passageiro : Entity
    {
        public Passageiro(Guid id, string nome, string telefone, decimal avaliacaoMedia) : base()
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            AvaliacaoMedia = avaliacaoMedia;
        }
        
        public string Nome{get; private set;}
        public string Telefone{get; private set;}
        public decimal AvaliacaoMedia{get; private set;}
    }
}