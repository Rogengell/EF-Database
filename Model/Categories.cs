using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFDatabase.Model
{
    public class Categories
    {
        [Key]
        public int categorId { get; set; }
        public string? CategoriesName { get; set; }
        [ForeignKey("CategoryId")]
        public ICollection<Products>? Products { get; set; }
    }
}