using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTOs.Book
{
    public class CreateBookDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
