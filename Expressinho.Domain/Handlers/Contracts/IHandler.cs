using Expressinho.Domain.Commands.Contracts;

namespace Expressinho.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}