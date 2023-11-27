using System.ComponentModel.DataAnnotations;

namespace WSAD_Final_Project.Models
{
    public class GolfGear
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}
