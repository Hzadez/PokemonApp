using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon_Domain.Entities;

namespace TaskPokemon.Contracts.Contracts
{
    public interface IGenericService<TEntity, TDto> where TEntity : BaseEntity, new() where TDto : class
    {
        Task<TDto> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> AddAsync(TDto entity);
        Task<TDto> UpdateAsync(TDto entity);
        Task<bool> DeleteAsync(int id);
    }
}
