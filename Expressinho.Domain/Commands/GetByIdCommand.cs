using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class GetByIdCommand : Contract<GetByIdCommand>,ICommand
    {
        public GetByIdCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id {get; private set;}
        public void Validate()
        {
            AddNotifications(Requires().IsNotNull(Id,"Id não pode ser nulo"));
        }
    }
}