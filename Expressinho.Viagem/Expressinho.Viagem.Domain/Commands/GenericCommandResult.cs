using Expressinho.Viagem.Domain.Commands.Contracts;

namespace Expressinho.Viagem.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult(){}

        public GenericCommandResult(bool sucesso, string mensagem, object objeto)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Objeto = objeto;
        }

        public bool Sucesso {get; private set;}
        public string Mensagem {get; private set;}
        public object Objeto {get; private set;}
    }
}