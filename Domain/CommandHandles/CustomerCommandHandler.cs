using Domain.Commands.Inputs;
using Domain.Handlers;
using MediatR;

namespace Domain.CommandHandles
{
    public class CustomerCommandHandler : CommandHandler,
        INotificationHandler<RegisterNewCustomerCommand>,
        INotificationHandler<UpdateCustomerCommand>,
        INotificationHandler<RemoveCustomerCommand>
    {
        private readonly ICostomerRepository _costomerRepository;
        private readonly IMediatorHandler Bus;

        public CustomerCommandHandler(ICustomerRepository customerRepository,
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications)
        {
            _costomerRepository = costomerRepository;
            Bus = bus;
        }
    }
}
