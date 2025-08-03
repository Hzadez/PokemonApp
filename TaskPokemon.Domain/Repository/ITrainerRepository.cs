using TaskPokemon_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Repository
{
    public interface ITrainerRepository: IGenericRepository<Trainer>
    {
        Task<List<TrainerPokemon>> GetPokemonByTrainerIdAsync(int trainerId);
    }
}
