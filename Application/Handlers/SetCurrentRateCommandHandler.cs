using MediatR;
using Microsoft.Extensions.Logging;
using Web.Api.Application.Commands;
using Web.Api.Models;
using Web.Domain.AggregatesModel.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Api.Application.Handlers
{
    public class SetCurrentRateCommandHandler
        : IRequestHandler<SetCurrentRateCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;
        private readonly ILogger<SetCurrentRateCommandHandler> _logger;

        // Using DI to inject infrastructure persistence Repositories
        public SetCurrentRateCommandHandler(IMediator mediator,
            ILogger<SetCurrentRateCommandHandler> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<bool> Handle(SetCurrentRateCommand request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
