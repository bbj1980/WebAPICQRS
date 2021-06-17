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
    public class RateHistoryCommandHandler
        : IRequestHandler<RateHistoryCommand, List<RateHistoryResponse>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;
        private readonly ILogger<RateHistoryCommandHandler> _logger;

        // Using DI to inject infrastructure persistence Repositories
        public RateHistoryCommandHandler(IMediator mediator,
            IUserRepository userRepository,
            ILogger<RateHistoryCommandHandler> logger)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));

            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<List<RateHistoryResponse>> Handle(RateHistoryCommand request, CancellationToken cancellationToken)
        {
            return new List<RateHistoryResponse>();
        }
    }
}
