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
    public class PokemonRepository : GenericRepository<Pokemon>, IPokemonRepository
    {
        public PokemonRepository(PokemonGameDbContext context) : base(context)
        {
        }


        public async Task<List<Category>> GetCategoriesByIdsAsync(List<int> categoryIds)
        {
            var datas = await _context.Categories
                   .Where(c => categoryIds.Contains(c.Id) && !c.IsDeleted)
                   .ToListAsync();
            return datas;
        }

        public async Task<Pokemon> UploadImgAsyn(int id, string imagePath)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                throw new ArgumentException("Pokemon not found");
            }
            pokemon.ImageUrl = imagePath;

            _context.Update(pokemon);
            await _context.SaveChangesAsync();
            return pokemon;
        }

        public override async Task<IEnumerable<Pokemon>> GetAllAsync()
        {
            var data = await _context.Pokemons
                .Include(c => c.Categories)
                .Where(c => !c.IsDeleted)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }

        public async Task<List<Skill>> GetSkillByIdsAsync(List<int> skillIds)
        {
            var datas = await _context.Skills.Where(c => skillIds.Contains(c.Id) && !c.IsDeleted).ToListAsync();
            return datas;
        }
    }

}
