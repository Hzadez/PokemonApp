using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPokemon.Contracts.Dtos
{
    public record class FileUploadDto
    {
        public IFormFile Image { get; set; } // The image file to be uploaded

    }
}
