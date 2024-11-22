using Expressinho.Viagem.Domain.Commands.Contracts;
using Expressinho.Viagem.Domain.Entities;
using Expressinho.Viagem.Domain.Enums;


namespace Expressinho.Viagem.Domain.Commands
{
    public class CriarViagemCommand : ICommand
    {
        public CriarViagemCommand(){}

        public CriarViagemCommand
        (
            string origem, 
            string destino, 
            EMetodoPagamento metodoPagamento,
            EMetodoViagem metodoViagem,
            EQuantidadeSacola quantidadeSacola,
            Passageiro passageiro,
            Motorista motorista,
            decimal distancia
        )
        {
            Origem = origem;
            Destino = destino;
            MetodoPagamento = metodoPagamento;
            MetodoViagem = metodoViagem;
            QuantidadeSacola = quantidadeSacola;
            Passageiro = passageiro;
            Motorista = motorista;
            Distancia = distancia;
                 
        }
        public string Origem {get; private set;}
        public string Destino {get; private set;}
        public DateTime HorarioInicio{get; private set;}
        public DateTime HorarioFim{get; private set;}
        public decimal Preco{get; private set;}
        public decimal AvaliacaoPassageiro{get; private set;}
        public decimal AvaliacaoMotorista{get; private set;}
        public decimal Distancia{get; private set;}
        public EMetodoPagamento MetodoPagamento{get; private set;}
        public EMetodoViagem MetodoViagem{get; private set;}
        public EQuantidadeSacola QuantidadeSacola{get; private set;}
        public Passageiro Passageiro{get; private set;}
        public Motorista Motorista{get; private set;}

    }
}