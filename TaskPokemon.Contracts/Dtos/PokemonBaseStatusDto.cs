using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record PokemonBaseStatusDto : BaseDto
    {
        public int Attack { get; set; } 
        public int Defense { get; set; }        
        public int Speed { get; set; }
        public int PokemonId { get; set; }
    }
}
