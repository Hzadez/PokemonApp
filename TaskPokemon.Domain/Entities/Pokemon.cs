using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon_Domain.Entities
{
    public class Pokemon : BaseEntity
    {
        public string Name { get; set; }
        public int HP { get; set; } 
        public int Level { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();
    }
}
