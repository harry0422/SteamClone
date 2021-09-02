using Microsoft.EntityFrameworkCore;
using StreamClone.Domain.Model.Games;
using StreamClone.Domain.Users.Model;

namespace SteamClone.Infrastructure.Games.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Wish> WishLists { get; set; }
    }
}