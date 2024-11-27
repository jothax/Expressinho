using Expressinho.Domain.Commands;
using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Handlers.Contracts;
using Expressinho.Domain.Repositories;
using Expressinho.Viagem.Domain.Commands;

namespace Expressinho.Domain.Handlers
{
    public class CarHandler : IHandler<CreateCarCommand>/* , IHandler<GetByIdCommand> */
    {
        private readonly ICarRepository _carRepository;
        
        public CarHandler(ICarRepository repository)
        {
            _carRepository = repository;
        }

        public ICommandResult Handle(CreateCarCommand command)
        {
            command.Validate();
            if(command.IsValid == false)
                return new GenericCommandResult(false,"Algo deu errado!", command.Notifications);

            var car = new Car(command.Model, command.Year, command.Plate, command.IdMotorist);

            _carRepository.Create(car);

            return new GenericCommandResult(true, "Carro adicionado com sucesso", car);
        }

        /* public ICommandResult Handle(GetByIdCommand command)
        {
            command.Validate();
            if(command.IsValid)
                return new GenericCommandResult(false,"Algo deu errado!", command.Notifications);

            var car = _carRepository.GetByMotoistId(command.Id);

            return new GenericCommandResult(true, "Carros pelo id do motorista",car);
        } */
    }
}