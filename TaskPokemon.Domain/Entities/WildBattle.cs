using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Entities
{
    public class WildBattle : BaseEntity
    {
        public int WildPokemonId { get; set; }
        public WildPokemon WildPokemon { get; set; }
        public int TrainerPokemonId { get; set; }
        public TrainerPokemon Trainer { get; set; }
        public DateTime BattleDate { get; set; } = DateTime.UtcNow;
        public bool? TrainerWin { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public string? Result { get; set; }
    }
}
