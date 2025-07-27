using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPokemon_Domain.Entities;

namespace TaskPokemon.Persistance.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100); // Set maximum length for Name
            builder.Property(c => c.Description)
                .HasMaxLength(500); // Set maximum length for Description
            // Configure the relationship with Pokemon
            builder.HasMany(c => c.Pokemons)
                .WithMany(p => p.Categories) // Assuming Pokemon has a Category navigation property             
                .UsingEntity(j => j.ToTable("PokemonCategories")); // Specify the join table name
                                                                   // Optionally, you can configure the join table further if needed

        }
    }
}
