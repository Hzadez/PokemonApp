using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record  GymDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public int LeaderTrainerPokemonId { get; set; }
        public List<int> BattlesIds { get; set; } = new List<int>();
    }
}
