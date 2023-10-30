using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetail
    {
        public int Order_id { get; set; }
        public int Product_id { get; set;}
        public int Quantity { get; set;}
        public double Discount { get; set;}
    }
}
