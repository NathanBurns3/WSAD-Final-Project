using System.ComponentModel.DataAnnotations;

namespace WSAD_Final_Project.Models
{
    public enum GearType
    {
        Snowboard,
        Bindings,
        Boots,
        Jacket,
        Pants,
        Goggles,
        Helmet,
        Gloves,
        BaseLayer,
        Socks,
        Backpack,
        Other
    }

    public enum Brand
    {
        Burton,
        K2,
        Ride,
        LibTech,
        GNU,
        Rome,
        Arbor,
        NeverSummer,
        Union,
        Vans,
        Oakley,
        Smith,
        Other
    }

    public class SnowboardGear
    {
        [Key]
        public int GearId { get; set; }

        public GearType? GearType { get; set; }

        public Brand? Brand { get; set; }

        public string? Model { get; set; }
    }
}