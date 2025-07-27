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
    public class GymService : GenericService<Gym, GymDto>, IGymService
    {
        private readonly IGymRepository _gymRepository;
        public GymService(IGymRepository repository, IMapper mapper, GymValidator validator) : base(repository, mapper, validator)
        {
            _gymRepository = repository;
        }
    }
}
