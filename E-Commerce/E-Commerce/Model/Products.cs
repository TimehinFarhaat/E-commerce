using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Products
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int SellingPrice { get; set; }
        public int Quantity { get; set; }
        public int AdminId { get; set; }
        public  Admin Admin { get; set; }
        public int CostPrice { get; set; }
        public virtual List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
