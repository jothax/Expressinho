using Expressinho.Domain.Commands.Contracts;

namespace Expressinho.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult(bool sucess, string message, object data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }

        public GenericCommandResult(bool sucess, string message, object[] data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }

        public bool Sucess {get; private set;}
        public string Message {get; private set;}
        public object Data {get; private set;}
    }
}