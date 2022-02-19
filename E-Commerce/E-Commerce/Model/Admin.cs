using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class Admin
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Products> Product { get; set; }

    }
}
