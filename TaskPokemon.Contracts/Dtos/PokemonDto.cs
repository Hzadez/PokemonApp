using TaskPokemon_Domain.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record PokemonDto : BaseDto
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsWild { get; set; }
        public PokemonBaseStatusDto PokemonBaseStatus  { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public List<int> SkillIds { get; set; } = new List<int>();

        public int? LocationId { get; set; }


	}
}
