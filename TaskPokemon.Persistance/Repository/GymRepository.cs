using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon_Domain.Entities;
using TaskPokemon.Persistance.Database;
using TaskPokemon_Domain.Repository;

namespace TaskPokemon.Persistance.Repository
{
    public class GymRepository : GenericRepository<Gym>, IGymRepository
    {
        public GymRepository(PokemonGameDbContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Gym>> GetAllAsync()
        {
            var datas = await _context.Gyms
                .Include(x => x.LeaderTrainerPokemonId)
                .Include(x => x.Location)
                .Include(x => x.Battles)
                .Where(c => !c.IsDeleted)
                .AsNoTracking()
                .ToListAsync();
            return datas;
        }
    }
}
