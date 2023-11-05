using MediatR;
using System.Text.Json.Serialization;

namespace ColourMemoryWithBlazor.Application.Features.Deck.Queries.GetCalculationOfDraws
{
    public class CalulateDrawsQuery :IRequest<CalulationDrawsRespons>
    {
        [JsonPropertyName("firstdraw")]
        public string FirstDraw { get; set; }
        [JsonPropertyName("seconddraw")]
        public string SecondDraw { get; set; }
    }

    public class CalulationDrawsRespons
    {
        public CalulationDrawsRespons(string first, string second)
        {
            ColourFirstDraw = first;
            ColourSecondDraw = second;
        }
        public bool IsPair { get; set; }
        public string ColourFirstDraw { get; set; }
        public string ColourSecondDraw { get; set; }
    }
    public class GetCalculationOfDrawsHandler : IRequestHandler<CalulateDrawsQuery, CalulationDrawsRespons>
    {
        public Task<CalulationDrawsRespons> Handle(CalulateDrawsQuery request, CancellationToken cancellationToken)
        {
            var respons = new CalulationDrawsRespons(request.FirstDraw, request.SecondDraw);
            if (!request.FirstDraw.Equals(request.SecondDraw))
                respons.IsPair = false;
            else
                respons.IsPair = true;

            return Task.FromResult(respons); 

        }
    }
}
