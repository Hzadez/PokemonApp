using TaskPokemon.Contracts.Dtos;
using TaskPokemon_Domain.Entities;
using TaskPokemon_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon.Contracts.Contracts;

namespace PokemonGame.Contracts.Contracts
{
    public interface IWildBattleService : IGenericService<WildBattle, WildBattleDto>
    {
        Task AddTurnAsync(int battleId, int attackerId, int defenderId, BattleAction action, int turnNumber);

        Task<IEnumerable<WildBattleDto>> GetBattlesAsync();
    }
}
