using Microsoft.EntityFrameworkCore;

namespace WSAD_Final_Project.Models
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options) : base(options)
        {
        }

        public DbSet<Videogames> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Videogames>().HasData(
                new Videogames {GameId = 1, Title = "Sonic Frontiers", Developer = "Sega", ReleaseYear = 2022 },
                new Videogames {GameId = 2, Title = "Super Smash Bros. Ultimate", Developer = "Sora Ltd.", ReleaseYear = 2017 },
                new Videogames {GameId = 3, Title = "Super Smash Bros. Wii U", Developer = "Sora Ltd.", ReleaseYear = 2014 },
                new Videogames {GameId = 4, Title = "Mario Kart 8 Deluxe", Developer = "Nintendo", ReleaseYear = 2017 },
                new Videogames {GameId = 5, Title = "Sonic Colors", Developer = "Nintendo", ReleaseYear = 2010 },
                new Videogames {GameId = 6, Title = "Halo 4", Developer = "Microsoft", ReleaseYear = 2012 }
            );
        }
    }
}
