using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon.Application.Service;
using TaskPokemon.Contracts.Contracts;

namespace TaskPokemon.Application.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceRegistration(this IServiceCollection services)
        {
           services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddScoped<IPokemonService, PokemonService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ITrainerService, TrainerService>();
            services.AddScoped<ITrainerPokemonService, TrainerPokemonService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IGymService, GymService>();
            services.AddScoped<IWildPokemonService, WildPokemonService>();
			return services;
        }
    }
}
