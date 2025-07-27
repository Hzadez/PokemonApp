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
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        public SkillRepository(PokemonGameDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Skill>> GetAllAsync()
        {
            var datas = await _context.Skills
                 .Include(x => x.Pokemons)
                 .Where(c => !c.IsDeleted)
                 .AsNoTracking()
                 .ToListAsync();
            return datas;
        }

        public async Task<List<Pokemon>> GetPokemonsByIds(List<int> ints)
        {
            var datas = await _context.Pokemons
                .Where(c => ints.Contains(c.Id) && !c.IsDeleted)
                .ToListAsync();
            return datas;
        }
    }
}
