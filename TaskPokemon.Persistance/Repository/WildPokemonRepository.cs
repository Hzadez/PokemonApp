using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskPokemon.Persistance.Database;
using TaskPokemon_Domain.Entities;
using TaskPokemon_Domain.Repository;

namespace TaskPokemon.Persistance.Repository
{
	public class WildPokemonRepository : GenericRepository<WildPokemon>, IWildPokemonRepository
	{
		public WildPokemonRepository(PokemonGameDbContext context) : base(context)
		{
		}
		public override async Task<IEnumerable<WildPokemon>> GetAllAsync()
		{
			var datas = await _context.WildPokemons
				.Include(x => x.Location)
				.Include(t => t.WildBattles)
				.AsNoTracking()
				.Where(w => !w.IsDeleted)
			    .ToListAsync();
			return datas;

		}
	}
}
