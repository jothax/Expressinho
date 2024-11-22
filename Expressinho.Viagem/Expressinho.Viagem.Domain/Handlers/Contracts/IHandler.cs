using Expressinho.Viagem.Domain.Commands.Contracts;

namespace Expressinho.Viagem.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}