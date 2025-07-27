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
    public class TrainerPokemonRepository : GenericRepository<TrainerPokemon>, ITrainerPokemonRepository
    {
        public TrainerPokemonRepository(PokemonGameDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TrainerPokemon>> GetAllAsync()
        {
            var datas = await _context.TrainerPokemons
                .Include(tp => tp.Trainer)
                .Include(tp => tp.Pokemon)
                .ThenInclude(p => p.Skills) // Include skills of the Pokemon
                .Include(p => p.Pokemon) // Include category of the Pokemon
                .ThenInclude(p => p.Categories) // Include category of the Pokemon
                .Where(tp => !tp.IsDeleted)
                .AsNoTracking() // Use AsNoTracking for read-only operations
                .ToListAsync();
            return datas;
        }
    }
}
