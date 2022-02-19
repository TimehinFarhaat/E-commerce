using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Model
{
    class Leger
    {
        public int Id { get; set; }
        public  int OrderId  { get; set; }
        public Order Order { get; set; }
        public  DateTime MonthYear { get; set; }
    }
}
