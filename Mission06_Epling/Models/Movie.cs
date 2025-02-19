using System.ComponentModel.DataAnnotations;

namespace Mission06_Epling.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100.")]
        public int Year { get; set; }

        public string? Director { get; set; }  // Optional

        public string? Rating { get; set; }  // Optional

        [Required(ErrorMessage = "You must select Yes or No for Edited.")]
        public bool Edited { get; set; }

        [Required(ErrorMessage = "You must select Yes or No for Copied to Plex.")]
        public bool CopiedToPlex { get; set; }

        public string? LentTo { get; set; }  // Optional

        [MaxLength(25, ErrorMessage = "Notes must be 25 characters or fewer.")]
        public string? Notes { get; set; }  // Optional
    }
}
