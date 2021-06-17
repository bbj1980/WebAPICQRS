using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Common.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Application.Commands;

namespace Web.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger<RateController> _logger;
        private readonly string _currentUserId;
        private readonly string _currentRole;
        public RateController(IMediator mediator,
            ILogger<RateController> logger,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _logger = logger;
            _mediator = mediator;
            _currentUserId = httpContextAccessor.CurrentUserId();
            _currentRole = httpContextAccessor.CurrentRole();
            
        }
        
       // [Authorize]
        [HttpPost]
        [Route("RateHistory")]
        public async Task<ActionResult> RateHistory([FromBody] RateHistoryCommand rateHistoryCommand)
        {
            var commandResult = await _mediator.Send(rateHistoryCommand);
            _logger.LogInformation("Rate history called");
         
            return Ok(commandResult);
        }
      //  [Authorize]
        [HttpGet]
        [Route("CurrentRate")]
        public async Task<ActionResult> CurrentRate([FromQuery] int id)
        {
            //int commandResult = await _mediator.Send();
            _logger.LogInformation("Current rate called");
           

            return Ok(1);
        }

       // [Authorize]
        [HttpPost]
        [Route("SetCurrentRate")]
        public async Task<ActionResult> SetCurrentRate([FromBody] SetCurrentRateCommand setCurrentCommand)
        {
            var commandResult = await _mediator.Send(setCurrentCommand);
            _logger.LogInformation("Set current rate called");


            return Ok(commandResult);
        }

    }
}
