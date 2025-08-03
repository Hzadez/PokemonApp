using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record LocationDto :BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> GymsIds { get; set; } = new List<int>(); 
        public List<int> WildPokemonsIds { get; set; } = new List<int>(); 
        public List<int> WildBattlesIds { get; set; } = new List<int>(); 
    }
}
