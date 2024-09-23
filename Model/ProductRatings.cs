using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDatabase.Model
{
    public class ProductRatings
    {
        public int ProductRatingsId { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
        public Products Products { get; set; }
    }
}