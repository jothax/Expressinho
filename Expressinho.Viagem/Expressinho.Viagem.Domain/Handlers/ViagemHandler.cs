using Expressinho.Viagem.Domain.Commands;
using Expressinho.Viagem.Domain.Commands.Contracts;
using Expressinho.Viagem.Domain.Handlers.Contracts;

namespace Expressinho.Viagem.Domain.Handlers
{
    public class ViagemHandler : IHandler<CriarViagemCommand>
    {
        public ICommandResult Handle(CriarViagemCommand command)
        {
            throw new NotImplementedException();
        }
    }
}