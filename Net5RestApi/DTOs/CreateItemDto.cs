using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Net5RestApi.DTOs
{
    public record CreateItemDto
    {
      
        [Required]
        public string Name { get; init; }

        [Required]
        [Range(1,500)]
        public decimal Price { get; init; }
    
    }
}
