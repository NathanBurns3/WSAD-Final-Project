using System.ComponentModel.DataAnnotations;

namespace WSAD_Final_Project.Models
{
    public enum CarMake
    {
        Acura,
        AlfaRomeo,
        AstonMartin,
        Audi,
        Bentley,
        BMW,
        Bugatti,
        Buick,
        Cadillac,
        Chevrolet,
        Chrysler,
        Dodge,
        Ferrari,
        Fiat,
        Ford,
        Genesis,
        GMC,
        Honda,
        Hyundai,
        Infiniti,
        Jaguar,
        Jeep,
        Kawasaki,
        Kia,
        Koenigsegg,
        Lamborghini,
        LandRover,
        Lexus,
        Lincoln,
        Lotus,
        Maserati,
        Mazda,
        McLaren,
        MercedesBenz,
        Mini,
        Mitsubishi,
        Nissan,
        Pagani,
        Polestar,
        Porsche,
        Ram,
        Rimac,
        RollsRoyce,
        Subaru,
        Suzuki,
        Tesla,
        Toyota,
        Volkswagen,
        Volvo,
        Other
    }

    public class Cars {
        [Key]
        public int CarId { get; set; }

        [Required(ErrorMessage = "Please enter a car make")]
        public CarMake? CarMake { get; set; }

        [Required(ErrorMessage = "Please enter a car model")]
        public string? CarModel { get; set; }

        [Required(ErrorMessage = "Please enter a car year")]
        public int? CarYear { get; set; }

        [Required(ErrorMessage = "Please enter when you bought the car")]
        [Range(1900, 2023, ErrorMessage = "Please enter a valid bought year")]
        public int? BoughtYear { get; set; }
    }
}