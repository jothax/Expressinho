using Expressinho.Domain.Commands;
using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Handlers.Contracts;
using Expressinho.Domain.Repositories;

namespace Expressinho.Domain.Handlers
{
    public class PassagerHandler(IPassagerRepository passagerRepository) : 
    IHandler<CreatePassagerCommand>
    {
        private readonly IPassagerRepository _passagerRepository = passagerRepository;

        public ICommandResult Handle(CreatePassagerCommand command)
        {
            // FFV(Fail Fast Validation)
            command.Validate();
            if(command.IsValid == false)
                return new GenericCommandResult(false, "Algo deu errado",command.Notifications);
            //Encrypt password
            command.CryptPassword();

            var passager = new Passager(
                command.Name, 
                command.Email, 
                command.Phone,
                command.Gender,
                command.Password,
                command.Salt,
                command.Iterations,
                command.BirthDate
                );

            _passagerRepository.Create(passager);

            return new GenericCommandResult(true, "passageiro criado com sucesso", passager);
        }
    }
}