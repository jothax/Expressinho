using Expressinho.Domain.Commands;
using Expressinho.Domain.Commands.Contracts;
using Expressinho.Domain.Entities;
using Expressinho.Domain.Handlers.Contracts;
using Expressinho.Domain.Repositories;

namespace Expressinho.Domain.Handlers
{
    public class TravelHandler :
    IHandler<CreateTravelCommand>
    {
        private readonly ITravelRepository _travelRepository;
        private readonly IRatingRepository _ratingRepository;

        public TravelHandler(ITravelRepository travelRepository, IRatingRepository ratingRepository)
        {
            _travelRepository = travelRepository;
            _ratingRepository = ratingRepository;
        }

        public ICommandResult Handle(CreateTravelCommand command)
        {
            // FFV(Fail Fast Validation)
            command.Validate();
            if(command.IsValid == false)
                return new GenericCommandResult(false, "Algo deu errado",command.Notifications);
            
            // validate rating
            command.ReviseRate(command.PassagerRating);
            command.ReviseRate(command.MotoristRating);

            var travel = new Travel(
                command.Origin,
                command.Destiny,
                command.StartDate,
                command.FinishDate,
                command.Price,
                command.PaymentMethod,
                command.TripMethod,
                command.IdMotorist,
                command.IdPassager
                );

            var ratingPassager = new Rating(command.PassagerRating, command.IdPassager);
            var ratingMotorist = new Rating(command.MotoristRating, command.IdMotorist);

            _travelRepository.Create(travel);
            _ratingRepository.Create(ratingPassager);
            _ratingRepository.Create(ratingMotorist);

            return new GenericCommandResult(true, "Travela criado com sucesso", [travel, ratingPassager,ratingMotorist]);
        }
    }
}