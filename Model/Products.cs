using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDatabase.Model
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}