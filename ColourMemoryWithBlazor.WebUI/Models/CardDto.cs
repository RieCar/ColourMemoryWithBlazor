namespace ColourMemoryWithBlazor.WebUI.Models
{
    public class CardDto
    {
        public string Colour { get; set; }
        public string ImagePath { get; set; }
        public Guid RefrenceId { get; set; }

        public bool IsClicked { get; set; }
        public bool IsFoundPair { get; set; }
        public CardDto()
        {

        }
        public CardDto(string colour, string imagePath)
        {
            Colour = colour;
            ImagePath = imagePath;
            RefrenceId = Guid.NewGuid();
            IsClicked = false;
        }
    }
}
