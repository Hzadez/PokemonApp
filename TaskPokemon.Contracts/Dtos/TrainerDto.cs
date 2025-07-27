using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record TrainerDto : BaseDto
    {
        public string Name { get; set; }
        public List<int> TrainerPokemonsIds { get; set; } = new List<int>(); // Navigation property to the Pokemons owned by the trainer
    }

}
