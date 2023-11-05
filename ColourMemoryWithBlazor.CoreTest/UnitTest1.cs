using ColourMemoryWithBlazor.Application.Extensions;
using ColourMemoryWithBlazor.Domain.Entities;

namespace ColourMemoryWithBlazor.CoreTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(5)]
        public void CreateDeckWithUnEventSize_ShouldThrow(int size)
        {

            var deck = Deck.CreateDeck(size);

            Assert.Throws<Exception>(() => deck.CreateDeckWithSize());

        }
        [TestCase(6)]
        [TestCase(10)]
        public void CreateDeckWithSize2(int size)
        {
            var deck = Deck.CreateDeck(size);

            var deckWithCards = deck.CreateDeckWithSize();

            Assert.AreEqual(size, deckWithCards.Cards.Count());

        }

        [TestCase(6)]
        public void CheckOriginalColour(int size)
        {
            var deck = Deck.CreateDeck(size);

            var deckWithCards = deck.CreateDeckWithSize();

           var groups =  deckWithCards.Cards.GroupBy(x => x.Colour);
            var amountOfColours = size / 2; 


            Assert.AreEqual(amountOfColours, groups.Count());

        }
    }


}