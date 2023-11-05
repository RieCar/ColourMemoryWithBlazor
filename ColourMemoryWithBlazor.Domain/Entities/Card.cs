using ColourMemoryWithBlazor.Domain.Common;
using ColourMemoryWithBlazor.Domain.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourMemoryWithBlazor.Domain.Entities
{
    public class Card : BaseEntity
    {
        public string Colour { get; set; }
        public string ImagePath { get; set; }

        public static Card CreateCard()
        {
            return new Card(); 
        }

    
    }
}
