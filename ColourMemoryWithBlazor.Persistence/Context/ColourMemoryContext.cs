using ColourMemoryWithBlazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColourMemoryWithBlazor.Persistence.Context
{
    public class ColourMemoryContext :DbContext
    {
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Deck> Decks { get; set; }

        public ColourMemoryContext(DbContextOptions<ColourMemoryContext> options) : base(options)
        {
                
        }
  
    }


}
