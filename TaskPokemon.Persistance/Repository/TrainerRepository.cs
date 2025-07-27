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
    public class TrainerRepository : GenericRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(PokemonGameDbContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Trainer>> GetAllAsync()
        {
            var datas = await _context.Trainers
               .Include(t => t.TrainerPokemon)
               .ThenInclude(tp => tp.Pokemon)
                 .Where(t => !t.IsDeleted)
                 .AsNoTracking()
                 .ToListAsync();
            return datas;
        }
    }
}
