using System.ComponentModel.DataAnnotations;

namespace WSAD_Final_Project.Models
{
    public class Videogames
    {
        [Key]
        [Required(ErrorMessage = "Please Enter a Game ID")]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please Enter a Game Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please Enter the Game Developer")]
        public string? Developer { get; set; }

        [Required(ErrorMessage = "Please Enter the Game Release Year")]
        public int? ReleaseYear { get; set; }
    }
}
