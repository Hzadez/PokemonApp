using AutoMapper;
using FluentValidation;
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
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {
       private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper, IValidator<CategoryDto> validator)
            : base(categoryRepository, mapper, validator)
        {
            _categoryRepository = categoryRepository;
        }
        // You can add any specific methods for CategoryService here if needed

        public override async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public override async Task<CategoryDto> AddAsync(CategoryDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "PokemonDto cannot be null");
            }
            var pokemon = await _categoryRepository.GetPokemonsByIds(dto.PokemonIds);
            var foundIds = pokemon.Select(c => c.Id).ToList();

            if (pokemon == null || !pokemon.Any())
            {
                throw new ArgumentException("pokemon not found");
            }
         
            var entity = _mapper.Map<Category>(dto);
            entity.Pokemons = pokemon;

            var addedData = await _categoryRepository.AddAsync(entity);
            var responseDto = _mapper.Map<CategoryDto>(addedData);
            return responseDto;

        }
    }
}
