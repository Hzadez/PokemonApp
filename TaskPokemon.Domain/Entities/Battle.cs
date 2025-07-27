using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Entities
{
    public class Battle : BaseEntity
    {
        public int TrainerPokemon1Id { get; set; }
        public TrainerPokemon TrainerPokemon1 { get; set; }

        public int TrainerPokemon2Id { get; set; }
        public TrainerPokemon TrainerPokemon2 { get; set; }

        public DateTime BattleDate { get; set; } = DateTime.UtcNow;

        public int? TrainerPokemonWinnerId { get; set; }
        public TrainerPokemon Winner { get; set; } 
        public int? TrainerPokemonLoserId { get; set; } 
        public TrainerPokemon Loser { get; set; } 

        public int GymId { get; set; }
        public Gym Gym { get; set; }

    }
}
