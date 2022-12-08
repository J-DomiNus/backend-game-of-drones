using backend_game_of_drones.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_game_of_drones
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Player> Player { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {
        }
    }
}
