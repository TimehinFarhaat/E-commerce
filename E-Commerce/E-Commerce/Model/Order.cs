using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Model;


namespace E_Commerce
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public virtual List<OrderProduct> OrderProducts { get; set; }=new List<OrderProduct>();
       public virtual List<Leger>Legers { get; set; }=new List<Leger>();
    }
}
