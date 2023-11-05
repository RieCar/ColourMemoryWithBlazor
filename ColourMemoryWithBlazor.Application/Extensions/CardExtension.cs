using ColourMemoryWithBlazor.Domain.Common.Types;
using ColourMemoryWithBlazor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourMemoryWithBlazor.Application.Extensions
{
    public static class CardExtension
    {

        public static Card SetStatus(this Card card, string colour)
        {
            card.Colour = colour;
            return card;
        }
    }
}
