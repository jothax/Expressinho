using Expressinho.Domain.Commands;
using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Handlers.Contracts;
using Expressinho.Domain.Repositories;

namespace Expressinho.Domain.Handlers
{
    public class TravelHandler(ITravelRepository travelRepository) : 
    IHandler<CreateTravelCommand>
    {
        private readonly ITravelRepository _travelRepository = travelRepository;

        public ICommandResult Handle(CreateTravelCommand command)
        {
            // FFV(Fail Fast Validation)
            command.Validate();
            if(command.IsValid == false)
                return new GenericCommandResult(false, "Algo deu errado",command.Notifications);
            // validate rating
            command.ReviseRate(command.UserRating);
            command.ReviseRate(command.DriverRating);

            var travel = new Travel(
                command.Origin,
                command.Destiny,
                command.StartDate,
                command.FinishDate,
                command.Price,
                command.UserRating,
                command.DriverRating,
                command.PaymentMethod,
                command.TripMethod,
                command.Motorist,
                command.Passager
                );

            _travelRepository.Create(travel);

            return new GenericCommandResult(true, "Travela criado com sucesso", travel);
        }
    }
}