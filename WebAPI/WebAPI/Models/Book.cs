using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime Create { get; set; }
    }
}
