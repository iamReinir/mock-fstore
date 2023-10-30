using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Weight {  get; set; }
        public decimal? Unit_price {  get; set; }
        public int? Unit_instock { get; set; }
    }
}
