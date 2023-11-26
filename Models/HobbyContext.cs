using Microsoft.EntityFrameworkCore;

namespace WSAD_Final_Project.Models
{
    public class HobbyContext: DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options) : base(options)
        {

        }

        public DbSet<SnowboardGear> SnowboardGear { get; set; }

        public DbSet<GolfGear> golfGears { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SnowboardGear>().HasData(
                new SnowboardGear { GearId = 1, GearType = GearType.Snowboard, Brand = Brand.Burton, Model = "Custom" },
                new SnowboardGear { GearId = 2, GearType = GearType.Bindings, Brand = Brand.Union, Model = "Force" },
                new SnowboardGear { GearId = 3, GearType = GearType.Boots, Brand = Brand.Vans, Model = "Hi-Standard" },
                new SnowboardGear { GearId = 4, GearType = GearType.Jacket, Brand = Brand.Oakley, Model = "Snow Shell" },
                new SnowboardGear { GearId = 5, GearType = GearType.Goggles, Brand = Brand.Smith, Model = "I/O Mag" }
            );

            modelBuilder.Entity<GolfGear>().HasData(
                new GolfGear { Id = 1, Name = "Paradym", Brand = "Callaway", Type = "Driver"},
                new GolfGear { Id = 2, Name = "Stealth 2", Brand = "Taylormade", Type = "Driver" },
                new GolfGear { Id = 3, Name = "Vokey", Brand = "Titleist", Type = "Wedge" },
                new GolfGear { Id = 4, Name = "G425", Brand = "Ping", Type = "Irons" },
                new GolfGear { Id = 5, Name = "Spider", Brand = "Taylormade", Type = "Putter" }
            );
        }
    }
}