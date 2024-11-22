using Expressinho.Viagem.Domain.Enums;

namespace Expressinho.Viagem.Domain.Entities
{
    public class Viagem : Entity
    {
        public Viagem(
            string origem, 
            string destino, 
            EMetodoPagamento metodoPagamento,
            EMetodoViagem metodoViagem,
            EQuantidadeSacola quantidadeSacola,
            Passageiro passageiro,
            Motorista motorista
            ) : base()
            {
                Id = Guid.NewGuid();
                Origem = origem;
                Destino = destino;
                MetodoPagamento = metodoPagamento;
                MetodoViagem = metodoViagem;
                QuantidadeSacola = quantidadeSacola;
                Passageiro = passageiro;
                Motorista = motorista;
                ValorFixo = 3m;
            }

        public string Origem {get; private set;}
        public string Destino {get; private set;}
        public DateTime HorarioInicio{get; private set;}
        public DateTime HorarioFim{get; private set;}
        public decimal Preco{get; private set;}
        public decimal AvaliacaoPassageiro{get; private set;}
        public decimal AvaliacaoMotorista{get; private set;}
        public EMetodoPagamento MetodoPagamento{get; private set;}
        public EMetodoViagem MetodoViagem{get; private set;}
        public EQuantidadeSacola QuantidadeSacola{get; private set;}
        public Passageiro Passageiro{get; private set;}
        public Motorista Motorista{get; private set;}
        private decimal ValorFixo {get;}
        
        public decimal CalcularPreco(decimal distancia)
        {
            return Preco = (distancia * ValorFixo) + (decimal)QuantidadeSacola;
        }

        public void AtribuirAvaliacaoPassageiro(decimal avaliacao){ AvaliacaoPassageiro = avaliacao;}
        
        public void AtribuirAvaliacaoMotorista(decimal avaliacao){ AvaliacaoMotorista = avaliacao;}
        
        public void AtribuirHorarioInicio(){HorarioInicio = DateTime.Now;}
        public void AtribuirHorarioFim(){HorarioFim = DateTime.Now;}
    }
}