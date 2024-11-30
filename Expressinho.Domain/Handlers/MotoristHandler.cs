using Expressinho.Domain.Commands;
using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Handlers.Contracts;
using Expressinho.Domain.Repositories;

namespace Expressinho.Domain.Handlers
{
    public class MotoristHandler :
    IHandler<CreateMotoristCommand>
    {
        private readonly IMotoristRepository _motoristRepository;

        public MotoristHandler(IMotoristRepository motoristRepository)
        {
            _motoristRepository = motoristRepository;
        }

        public ICommandResult Handle(CreateMotoristCommand command)
        {
            // FFV(Fail Fast Validation)
            command.Validate();
            if(command.IsValid == false)
                return new GenericCommandResult(false, "Algo deu errado", command.Notifications);
            //Encrypt password
            command.CryptPassword();

            var motorist = new Motorist(
                command.Name, 
                command.Email, 
                command.Password,
                command.Salt,
                command.Iterations,
                command.BirthDate,
                command.Licence,
                command.LicenceCategory
                );

            _motoristRepository.Create(motorist);

            return new GenericCommandResult(true, "motorista criado com sucesso", motorist);
        }
    }
}