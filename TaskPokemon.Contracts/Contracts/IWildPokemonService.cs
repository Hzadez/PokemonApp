using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon.Contracts.Dtos;
using TaskPokemon_Domain.Entities;

namespace TaskPokemon.Contracts.Contracts
{
	public interface IWildPokemonService : IGenericService<WildPokemon,WildPokemonDto>
	{
	}
}
