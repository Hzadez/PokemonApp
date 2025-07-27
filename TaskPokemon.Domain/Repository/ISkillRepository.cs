using TaskPokemon_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Repository
{
    public interface ISkillRepository : IGenericRepository<Skill>
    {
        public Task<List<Pokemon>> GetPokemonsByIds(List<int> ints);
    }
}
