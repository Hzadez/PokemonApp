using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon.Persistance.Repository;
using TaskPokemon_Domain.Repository;

namespace TaskPokemon.Persistance.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IPokemonRepository, PokemonRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ITrainerRepository, TrainerRepository>();
            services.AddScoped<ITrainerPokemonRepository, TrainerPokemonRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IGymRepository, GymRepository>();
            services.AddScoped<IWildPokemonRepository, WildPokemonRepository>();
            return services;
        }
    }
}
