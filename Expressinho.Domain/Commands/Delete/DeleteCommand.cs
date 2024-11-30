using Expressinho.Domain.Commands.Contracts;
using Flunt.Validations;

namespace Expressinho.Domain.Commands
{
    public class DeleteCommand : Contract<DeleteCommand>,ICommand
    {
        public DeleteCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id{get; private set;}

        public void Validate()
        {
            AddNotifications
            (
                Requires()
                .IsNotEmpty(Id,"Não pode ser vazio")
            );
        }
    }
}