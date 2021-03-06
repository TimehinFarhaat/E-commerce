// <auto-generated />
using System;
using E_Commerce;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220216123234_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("E_Commerce.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("E_Commerce.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("E_Commerce.Model.Leger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("MonthYear")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Legers");
                });

            modelBuilder.Entity("E_Commerce.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("E_Commerce.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("CostPrice")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("E_Commerce.Model.Leger", b =>
                {
                    b.HasOne("E_Commerce.Order", "Order")
                        .WithMany("Legers")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Commerce.Order", b =>
                {
                    b.HasOne("E_Commerce.Customer", "customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("E_Commerce.OrderProduct", b =>
                {
                    b.HasOne("E_Commerce.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Products", "Products")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductsId");

                    b.Navigation("Order");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Commerce.Products", b =>
                {
                    b.HasOne("E_Commerce.Admin", "Admin")
                        .WithMany("Product")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("E_Commerce.Admin", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("E_Commerce.Order", b =>
                {
                    b.Navigation("Legers");

                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("E_Commerce.Products", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
