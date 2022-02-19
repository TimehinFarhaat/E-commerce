using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace E_Commerce
{
    class OrderProduct
    {
        public int Id { get; set; }
        public  int ProductId { get; set; }
        public int Quantity { get; set; }
        public Products Products { get; set; }
        public   int OrderId { get; set; }
        public  Order Order { get; set; }
    }
}
