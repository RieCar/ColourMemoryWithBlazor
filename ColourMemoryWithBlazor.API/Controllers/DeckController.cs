using ColourMemoryWithBlazor.Application.Features.Deck.Queries.GetCalculationOfDraws;
using ColourMemoryWithBlazor.Application.Features.Deck.Queries.GetDeckSpecificSize;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ColourMemoryWithBlazor.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeckController :ControllerBase
    {
        private readonly IMediator mediator;

        public DeckController(IMediator _mediator)
        {
            mediator = _mediator;
        }

        [HttpGet("bySize/{size:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromRoute] int size)
        {
            if (size % 2 == 0)
                return BadRequest("Invalid deck size"); 

            var query = new GetDeckSpecificSizeQuery(); 
            query.Size = size; 


            var respons = await mediator.Send(query, new CancellationToken()); 
            
            return Ok(respons);
        }

        [HttpGet("calculatedraws/{first}/{second}")]
        public async Task<IActionResult> Get([FromRoute] string first ,string second)
        {
            var query = new CalulateDrawsQuery() { FirstDraw = first, SecondDraw =second};

            var respons = await mediator.Send(query, new CancellationToken());

            return Ok(respons);
        }
    }

  

}
