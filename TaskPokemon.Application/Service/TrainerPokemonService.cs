using AutoMapper;
using FluentValidation;
using TaskPokemon.Application.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon.Contracts.Contracts;
using TaskPokemon.Contracts.Dtos;
using TaskPokemon_Domain.Entities;
using TaskPokemon_Domain.Repository;

namespace TaskPokemon.Application.Service
{
    public class TrainerPokemonService : GenericService<TrainerPokemon, TrainerPokemonDto>, ITrainerPokemonService
    {
        private readonly ITrainerPokemonRepository _trainerPokemonRepository;

        public TrainerPokemonService(ITrainerPokemonRepository trainerPokemonRepository, IMapper mapper, TrainerPokemonValidator validator) : base(trainerPokemonRepository, mapper, validator)
        {
            _trainerPokemonRepository = trainerPokemonRepository;
        }

        public override async Task<IEnumerable<TrainerPokemonDto>> GetAllAsync()
        {
            var datas = await _trainerPokemonRepository.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<TrainerPokemonDto>>(datas);
            return dtos;
        }
    }
}
