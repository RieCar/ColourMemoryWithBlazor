using ColourMemoryWithBlazor.Application.Extensions;
using ColourMemoryWithBlazor.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourMemoryWithBlazor.Core.Test
{
    [TestFixture]
    public class TestApplication
    {
        [TestCase(6)]
        public void CreateDeckWithSize2(int size)
        {

            var deck = Deck.CreateDeck(size);

            var deckWithCards = deck.CreateDeckWithSize();

            Assert.AreEqual(size, deckWithCards.Cards.Count());

        }
    }
}
