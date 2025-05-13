using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardGamesRating.Data
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string? Content { get; set; }
        
        [Range(0, 10)]
        public float Rating { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public string UserId { get; set; } = string.Empty;

    }
}
