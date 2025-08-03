using TaskPokemon.Contracts.Dtos;
using TaskPokemon_Domain.Entities;
using TaskPokemon_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Contracts
{
    public interface IBattleService : IGenericService<Battle,BattleDto>
    {
        Task AddTurnAsync(int battleId, int attackerId, int defenderId, BattleAction action, int turnNumber);
        
        Task<IEnumerable<BattleDto>> GetBattlesAsync();

	}
}
