using ColourMemoryWithBlazor.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourMemoryWithBlazor.Domain.Entities
{
    public class Deck : BaseEntity
    {
        public int Size { get; set; }
        public List<Card> Cards { get; set; }

        private Deck () {
            Cards = new List<Card> ();
        } 

        public static Deck CreateDeck(int size)
        {
            var deck = new Deck();

            deck.Size = size; 
            return deck;
        } 



    }
}
