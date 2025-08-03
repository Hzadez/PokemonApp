using TaskPokemon_Domain.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record TrainerPokemonDto : BaseDto
    {
        public int TrainerId { get; set; }
        public PokemonDto? Pokemon { get; set; }
        public DateTime CaughtAt { get; set; }
        public int Level { get; set; }
        public int CurrentHP { get; set; }
        public int Losses { get; set; } 
        public int Wins { get; set; } 
    }
}
