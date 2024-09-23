using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDatabase.Model
{
    public class Products
    {
        [Key]
        public int ProductsId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public Categories? Categories { get; set; }
    }
}