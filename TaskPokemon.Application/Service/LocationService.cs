using AutoMapper;
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
    public class LocationService : GenericService<Location, LocationDto>, ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository, IMapper mapper, LocationValidator validator) : base(locationRepository, mapper, validator)
        {
            _locationRepository = locationRepository;
        }
        public override async Task<IEnumerable<LocationDto>> GetAllAsync()
        {
            var datas = await _locationRepository.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<LocationDto>>(datas);
            return dtos;
        }
    }
}
