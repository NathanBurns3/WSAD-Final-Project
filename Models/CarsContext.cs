using Microsoft.EntityFrameworkCore;

namespace WSAD_Final_Project.Models;

public class CarsContext: DbContext
{
    public CarsContext(DbContextOptions<CarsContext> options) : base(options)
    {

    }

    public DbSet<Cars> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Cars>().HasData(
            new Cars { CarId = 1, CarMake = CarMake.Honda, CarModel = "Civic", CarYear = 2005, BoughtYear = 2016 },
            new Cars { CarId = 2, CarMake = CarMake.Honda, CarModel = "Civic", CarYear = 2006, BoughtYear = 2017 },
            new Cars { CarId = 3, CarMake = CarMake.Cadillac , CarModel = "CTS", CarYear = 2008, BoughtYear = 2018 },
            new Cars { CarId = 4, CarMake = CarMake.Toyota, CarModel = "MR2", CarYear = 1988, BoughtYear = 2018 },
            new Cars { CarId = 5, CarMake = CarMake.Honda, CarModel = "Del Sol", CarYear = 1994, BoughtYear = 2019},
            new Cars { CarId = 6, CarMake = CarMake.Ford, CarModel = "F150", CarYear = 1999, BoughtYear = 2021},
            new Cars { CarId = 7, CarMake = CarMake.Ford, CarModel = "F250", CarYear = 2001, BoughtYear = 2022},
            new Cars { CarId = 8, CarMake = CarMake.Mazda, CarModel = "B2000", CarYear = 1999, BoughtYear = 2023},
            new Cars { CarId = 9, CarMake = CarMake.Kawasaki, CarModel = "Ninja", CarYear = 2008, BoughtYear = 2022},
            new Cars { CarId = 10, CarMake = CarMake.Suzuki, CarModel = "GS750T", CarYear = 1982, BoughtYear = 2022}
        );
    }
}
