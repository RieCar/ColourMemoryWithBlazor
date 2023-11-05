
namespace ColourMemoryWithBlazor.WebUI.Models
{
    public class Deck
    {
        public int PossibleWins { get; set; }
        public List<CardDto> DeckOfCards { get; set; }
        public Deck()
        {

        }
    }
}
