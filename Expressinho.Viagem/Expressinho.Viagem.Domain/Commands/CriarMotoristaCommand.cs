using Expressinho.Viagem.Domain.Commands.Contracts;
using Expressinho.Viagem.Domain.Entities;

namespace Expressinho.Viagem.Domain.Commands
{
    public class CriarMotoristaCommand : ICommand
    {
        public CriarMotoristaCommand(){}
        
        public CriarMotoristaCommand(
            Guid id, 
            string nome, 
            string telefone, 
            decimal avaliacaoMedia,
            string localizacao,
            Carro carro
            )
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            AvaliacaoMedia = avaliacaoMedia;
            Localizacao = localizacao;
            Carro = carro;            
        }

        public Guid Id {get; private set;}
        public string Nome{get; private set;}
        public string Telefone{get; private set;}
        public decimal AvaliacaoMedia{get; private set;}
        public string Localizacao{get; private set;}
        public Carro Carro{get; private set;}

    }
}