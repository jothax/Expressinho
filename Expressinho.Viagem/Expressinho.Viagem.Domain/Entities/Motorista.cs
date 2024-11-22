namespace Expressinho.Viagem.Domain.Entities
{
    public class Motorista : Entity
    {
        public Motorista(
            Guid id, 
            string nome, 
            string telefone, 
            decimal avaliacaoMedia,
            string localizacao, 
            Carro carro)
            : base()
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            AvaliacaoMedia = avaliacaoMedia;
            Localizacao = localizacao;
            Carro = carro;
        }
        
        public string Nome{get; private set;}
        public string Telefone{get; private set;}
        public decimal AvaliacaoMedia{get; private set;}
        public string Localizacao{get; private set;}
        public Carro Carro{get; private set;}
    }
}