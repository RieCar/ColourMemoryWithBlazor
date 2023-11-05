using ColourMemoryWithBlazor.Application.Extensions;
using ColourMemoryWithBlazor.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ColourMemoryWithBlazor.Application.Features.Deck.Queries.GetDeckSpecificSize
{
    public class GetDeckSpecificSizeQuery :IRequest<GetDeckSpecificSizeRespons>
    {
        [Required]
        [JsonPropertyName("size")]
        public int Size { get; set; }
    }

    public class GetDeckSpecificSizeRespons
    {
        public int PossibleWins { get; set; }
        public List<CardDto> DeckOfCards { get; set; }
        public GetDeckSpecificSizeRespons()
        {
           
        }
    }

    public class CardDto
    {
        public string Colour { get; set; }
        public string ImagePath { get; set; }

        public CardDto()
        {
                
        }
        public CardDto(string colour, string imagePath)
        {
            Colour = colour;
            ImagePath = imagePath;
        }
    }
    public class GetDeckSpecificSizeHandler : IRequestHandler<GetDeckSpecificSizeQuery, GetDeckSpecificSizeRespons>
    {
        public Task<GetDeckSpecificSizeRespons> Handle(GetDeckSpecificSizeQuery request, CancellationToken cancellationToken)
        {

            var deck = Domain.Entities.Deck.CreateDeck(request.Size);

           var result = deck.CreateDeckWithSize();
            var response = new GetDeckSpecificSizeRespons
            {
                PossibleWins = result.Cards.Count()%2,
                DeckOfCards = result.Cards.Select(card => new CardDto(card.Colour, card.ImagePath)).ToList()
            };
            return Task.FromResult(response); 
        }

      
    }
}

