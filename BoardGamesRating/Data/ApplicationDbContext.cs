using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BoardGamesRating.Data;

namespace BoardGamesRating.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
