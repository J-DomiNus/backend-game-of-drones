using System.ComponentModel.DataAnnotations;

namespace backend_game_of_drones.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; } = null!;

        public int Wins { get; set; }

    }
}
