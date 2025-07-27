using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Entities
{
    public class Trainer : BaseEntity
    {
        public string Name { get; set; }       
        public ICollection<TrainerPokemon> TrainerPokemon { get; set; } = new List<TrainerPokemon>();     
       
    }
}
