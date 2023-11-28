using System.ComponentModel.DataAnnotations;

namespace WSAD_Final_Project.Models
{
    public class Videogames
    {
        [Key]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please Enter a Game Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please Enter the Game Developer")]
        public string? Developer { get; set; }

        [Required(ErrorMessage = "Please Enter the Game Release Year")]
        [Range(1900, 2023, ErrorMessage = "Please Enter a Valid Year (1900 - 2023)")]
        public int? ReleaseYear { get; set; }
    }
}
