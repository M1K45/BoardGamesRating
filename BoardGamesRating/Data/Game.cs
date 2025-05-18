using System.ComponentModel.DataAnnotations;

namespace BoardGamesRating.Data
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title{ get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float Rate { get; set; } = 0;
        public int NumRates { get; set; } = 0;

        public string? ImageUrl { get; set; }
    }
}
