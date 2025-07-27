using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Gym> Gyms { get; set; } = new List<Gym>();
        public ICollection<WildPokemon> WildPokemons { get; set; } = new List<WildPokemon>();
        public ICollection<WildBattle> WildBattles { get; set; } = new List<WildBattle>();

    }
}
