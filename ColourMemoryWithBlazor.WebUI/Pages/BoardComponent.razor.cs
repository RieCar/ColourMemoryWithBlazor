using ColourMemoryWithBlazor.WebUI.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Net.WebSockets;

namespace ColourMemoryWithBlazor.WebUI.Pages
{
    public partial class BoardComponent
    {
        [Inject]
        private HttpClient Http { get; set; }

        private Deck? deck;

        private CalculatedDraws? validationOfDraws;

        private bool IsPair = false;

        private Error? Error { get; set; }


        protected async Task GetDeck(int size)
        {
            try
            {
                deck = await Http.GetFromJsonAsync<Deck>($"/api/Deck/bySize/{size}");
            }
            catch (Exception)
            {

                var error = new Error();
                error.Message = "Failed to load. Try again";
            }
        }
        protected async Task CheckIfPair(string first, string second)
        {
            validationOfDraws = await Http.GetFromJsonAsync<CalculatedDraws>($"/api/Deck/calculatedraws/{first}/{second}");

            if (validationOfDraws != null)
            {
                IsPair = validationOfDraws.IsPair; 
            }
        }
    }
}
