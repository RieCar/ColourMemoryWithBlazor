using Microsoft.AspNetCore.Components;

namespace ColourMemoryWithBlazor.WebUI.Pages
{
    public partial class Index
    {

        [Inject]
        private HttpClient Http { get; set; }


        protected override async Task OnInitializedAsync()
        {
           // deck = await Http.GetFromJsonAsync<GetDeckSpecificSizeRespons>("/api/Deck/bySize/6");

        }
    }
}
