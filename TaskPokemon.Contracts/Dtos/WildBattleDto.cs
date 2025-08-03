using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record WildBattleDto : BaseDto
    {
        public int WildPokemonId     { get; set; }  
        public int TrainerPokemonId { get; set; }
        public DateTime BattleDate { get; set; } = DateTime.UtcNow;
        public int? WinnerId { get; set; } 
        public int? LoserId { get; set; } 
        public int LocationId { get; set; }
    }
}
