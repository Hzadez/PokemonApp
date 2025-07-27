using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon_Domain.Entities;

namespace TaskPokemon.Persistance.Database
{
    public class PokemonGameDbContext : DbContext
    {
        public PokemonGameDbContext(DbContextOptions<PokemonGameDbContext> options) : base(options)
        {

        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TrainerPokemon> TrainerPokemons { get; set; }
        public DbSet<WildPokemon> WildPokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PokemonGameDbContext).Assembly);
        }

    }
}
