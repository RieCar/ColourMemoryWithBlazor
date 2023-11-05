
using ColourMemoryWithBlazor.Domain.Common.Types;
using ColourMemoryWithBlazor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ColourMemoryWithBlazor.Application.Extensions
{
    public static class DeckExtension
    {
        public static Deck CreateDeckWithSize(this Deck deck)
        {

            if (deck.Size % 2 != 0)
            {
                throw new Exception("Deck size must be an even number.");
            }

            var possibleColors = new List<string>() { CardColour.Red, CardColour.Green, CardColour.Brown, CardColour.Grey, CardColour.Pink, CardColour.Blue, CardColour.Purple };
            deck.Cards = new List<Card>();

            Random random = new Random();
            var usedColours = new List<string>(); 
            for (int i = 0; i < deck.Size / 2; i++)
            {
                var randomColor = possibleColors[random.Next(possibleColors.Count)];
                if (usedColours.Contains(randomColor))
                {
                    do
                    {
                        randomColor = possibleColors[random.Next(possibleColors.Count)];
                    }
                    while (usedColours.Contains(randomColor));
                    
                }
                usedColours.Add(randomColor); 

                deck.Cards.Add(Card.CreateCard().SetStatus(randomColor));
                deck.Cards.Add(Card.CreateCard().SetStatus(randomColor));

            }

            deck.Cards = deck.Cards.OrderBy(card => random.Next()).ToList();

            return deck;

        }
    }
}
