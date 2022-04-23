using System.ComponentModel.DataAnnotations;

namespace MuSeek.Models
{
    public class Music
    {
        public int MusicId { get; set; }    // FK 

        [StringLength(100, ErrorMessage = "Title may not exceed 100 characters.")]
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Range(0, 2022, ErrorMessage = "Year must be between 0 and 2022.")]
        [Required(ErrorMessage = "Please enter a year.")]
        public int? Year { get; set; }

        public Music music { get; set; }

        public int ArtistId { get; set; }    // FK 

        public Artist artist { get; set; }
    }
}