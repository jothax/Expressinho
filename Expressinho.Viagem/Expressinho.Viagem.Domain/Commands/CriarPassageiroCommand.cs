using Expressinho.Viagem.Domain.Commands.Contracts;

namespace Expressinho.Viagem.Domain.Commands
{
    public class CriarPassageiroCommand : ICommand
    {
        public CriarPassageiroCommand(){}
        
        public CriarPassageiroCommand(Guid id, string nome, string telefone, decimal avaliacaoMedia)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            AvaliacaoMedia = avaliacaoMedia;            
        }

        public Guid Id {get; private set;}
        public string Nome{get; private set;}
        public string Telefone{get; private set;}
        public decimal AvaliacaoMedia{get; private set;}

    }
}