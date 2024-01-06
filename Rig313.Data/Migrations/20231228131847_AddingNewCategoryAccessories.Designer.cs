﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rig313.Data.DataAccess;

#nullable disable

namespace Rig313.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231228131847_AddingNewCategoryAccessories")]
    partial class AddingNewCategoryAccessories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rig313.Core.Carting.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Rig313.Core.Carting.CartItem", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("Rig313.Core.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Laptop Description",
                            DisplayOrder = 1,
                            ImageUrl = "SampleImageUrl",
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Desktop Description",
                            DisplayOrder = 2,
                            ImageUrl = "SampleImageUrl2",
                            Name = "Desktop"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Accessories",
                            DisplayOrder = 3,
                            ImageUrl = "SampleImageUrl3",
                            Name = "Accessories"
                        });
                });

            modelBuilder.Entity("Rig313.Core.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 89,
                            Address = "Customer Address",
                            Name = "Customer 1",
                            UserId = 89
                        });
                });

            modelBuilder.Entity("Rig313.Core.Inventories.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Delivered")
                        .HasColumnType("int");

                    b.Property<int>("OnPending")
                        .HasColumnType("int");

                    b.Property<int>("OnShipped")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StockAvailable")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Delivered = 0,
                            OnPending = 0,
                            OnShipped = 0,
                            ProductId = 1,
                            StockAvailable = 30
                        },
                        new
                        {
                            Id = 2,
                            Delivered = 0,
                            OnPending = 0,
                            OnShipped = 0,
                            ProductId = 2,
                            StockAvailable = 20
                        },
                        new
                        {
                            Id = 3,
                            Delivered = 0,
                            OnPending = 0,
                            OnShipped = 0,
                            ProductId = 3,
                            StockAvailable = 45
                        },
                        new
                        {
                            Id = 4,
                            Delivered = 0,
                            OnPending = 0,
                            OnShipped = 0,
                            ProductId = 4,
                            StockAvailable = 0
                        });
                });

            modelBuilder.Entity("Rig313.Core.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CancelDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<double>("PaidAmount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("PaymentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlacingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ProcessingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipmentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ShipmentCharge")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ShippingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Rig313.Core.Orders.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Rig313.Core.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Laptop1 Description",
                            Discount = 0.0,
                            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product01.png?alt=media&token=f6ab9d5e-2916-4bd9-9905-9ec8e9c37cf3",
                            Name = "Laptop 1",
                            Price = 60000.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Laptop2 Description",
                            Discount = 0.0,
                            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product03.png?alt=media&token=0d819674-53bf-41d0-8068-9b840799475e",
                            Name = "Laptop 2",
                            Price = 63000.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Desktop1 Description",
                            Discount = 0.050000000000000003,
                            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product06.png?alt=media&token=94a3f820-5f16-4aa3-91ba-2c35ae221f69",
                            Name = "Desktop 1",
                            Price = 48000.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Desktop2 Description",
                            Discount = 0.0,
                            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product08.png?alt=media&token=0b023b8b-533a-4b65-8f24-9183803a9e42",
                            Name = "Desktop 2",
                            Price = 50000.0
                        });
                });

            modelBuilder.Entity("Rig313.Core.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@rig313.com",
                            Password = "amdin",
                            Phone = "+880123456789",
                            UserRole = 1,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 89,
                            Email = "customer@rig313.com",
                            Password = "customer",
                            Phone = "+880123456780",
                            UserRole = 2,
                            Username = "customer"
                        });
                });

            modelBuilder.Entity("Rig313.Core.Users.UserPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CategoryManager")
                        .HasColumnType("bit");

                    b.Property<bool>("Customer")
                        .HasColumnType("bit");

                    b.Property<bool>("CustomerManager")
                        .HasColumnType("bit");

                    b.Property<bool>("InventoryManager")
                        .HasColumnType("bit");

                    b.Property<bool>("ProductManager")
                        .HasColumnType("bit");

                    b.Property<bool>("SuperAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserPermissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryManager = true,
                            Customer = false,
                            CustomerManager = true,
                            InventoryManager = true,
                            ProductManager = true,
                            SuperAdmin = true,
                            UserId = 1
                        },
                        new
                        {
                            Id = 89,
                            CategoryManager = false,
                            Customer = true,
                            CustomerManager = false,
                            InventoryManager = false,
                            ProductManager = false,
                            SuperAdmin = false,
                            UserId = 89
                        });
                });

            modelBuilder.Entity("Rig313.Core.Carting.Cart", b =>
                {
                    b.HasOne("Rig313.Core.Customers.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("Rig313.Core.Carting.Cart", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Rig313.Core.Carting.CartItem", b =>
                {
                    b.HasOne("Rig313.Core.Carting.Cart", "Carts")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rig313.Core.Products.Product", "Product")
                        .WithOne("CartItem")
                        .HasForeignKey("Rig313.Core.Carting.CartItem", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Rig313.Core.Customers.Customer", b =>
                {
                    b.HasOne("Rig313.Core.Users.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("Rig313.Core.Customers.Customer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Rig313.Core.Inventories.Inventory", b =>
                {
                    b.HasOne("Rig313.Core.Products.Product", "Product")
                        .WithOne("Inventories")
                        .HasForeignKey("Rig313.Core.Inventories.Inventory", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Rig313.Core.Orders.Order", b =>
                {
                    b.HasOne("Rig313.Core.Customers.Customer", "Customer")
                        .WithOne("Order")
                        .HasForeignKey("Rig313.Core.Orders.Order", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Rig313.Core.Orders.OrderItem", b =>
                {
                    b.HasOne("Rig313.Core.Orders.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rig313.Core.Products.Product", "Product")
                        .WithOne("OrderItem")
                        .HasForeignKey("Rig313.Core.Orders.OrderItem", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Rig313.Core.Products.Product", b =>
                {
                    b.HasOne("Rig313.Core.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Rig313.Core.Users.UserPermission", b =>
                {
                    b.HasOne("Rig313.Core.Users.User", "User")
                        .WithOne("UserPermission")
                        .HasForeignKey("Rig313.Core.Users.UserPermission", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Rig313.Core.Carting.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Rig313.Core.Categories.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Rig313.Core.Customers.Customer", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("Rig313.Core.Orders.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Rig313.Core.Products.Product", b =>
                {
                    b.Navigation("CartItem")
                        .IsRequired();

                    b.Navigation("Inventories")
                        .IsRequired();

                    b.Navigation("OrderItem")
                        .IsRequired();
                });

            modelBuilder.Entity("Rig313.Core.Users.User", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();

                    b.Navigation("UserPermission");
                });
#pragma warning restore 612, 618
        }
    }
}
