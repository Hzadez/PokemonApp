using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Entities
{
    public class TrainerPokemon : BaseEntity
    {
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public DateTime CaughtAt { get; set; }
        public int Level { get; set; }
        public int CurrentHP { get; set; }
       
    }
}
