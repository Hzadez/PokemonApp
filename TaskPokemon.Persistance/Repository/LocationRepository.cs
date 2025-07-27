using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon.Persistance.Database;
using TaskPokemon_Domain.Entities;
using TaskPokemon_Domain.Repository;

namespace TaskPokemon.Persistance.Repository
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(PokemonGameDbContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Location>> GetAllAsync()
        {
            var datas = await _context.Locations
                .Include(x => x.Gyms).ThenInclude(x => x.LeaderTrainerPokemonId)
                .Include(x => x.WildPokemons)
                .Include(x => x.WildBattles)
                .Where(c => !c.IsDeleted)
                .AsNoTracking()
                .ToListAsync();
            return datas;

        }
    }
}
