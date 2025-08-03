using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
	public record WildPokemonDto : BaseDto
	{
		public int PokemonId { get; set; }
		public int Level { get; set; }
		public int CurrentHP { get; set; } 
		public DateTime AppearedAt { get; set; } = DateTime.UtcNow.AddHours(4); 
        public int LocationId { get; set; } 
	}
}
