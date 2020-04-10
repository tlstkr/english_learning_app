using System;
using english_learning_app.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace english_learning_app.Data
{
    public class FlashcardDbContext:IdentityDbContext<ApplicationUser>
    {
        public FlashcardDbContext(DbContextOptions<FlashcardDbContext> options)
            : base(options)
        { }

        public DbSet<Deck> Decks { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
