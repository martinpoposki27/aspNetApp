using System.ComponentModel.DataAnnotations;

namespace albumsMVC.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Display(Name = "Artist Name")]
        [Required]
        public string Name { get; set; }
    }
}