using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Model;
using Microsoft.EntityFrameworkCore;


namespace E_Commerce
{
    class ApplicationContext:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=E-Commerce;user=root;password=alfawwazstaa99");
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Leger>Legers { get; set; }
    }
}
