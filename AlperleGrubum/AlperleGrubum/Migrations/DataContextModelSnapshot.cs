﻿// <auto-generated />
using System;
using AlperleGrubum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlperleGrubum.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlperleGrubum.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AlperleGrubum.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<int>("EmployeeId");

                    b.Property<decimal>("Freight");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderDetailId");

                    b.Property<DateTime>("RequiredDate");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("ShipVia");

                    b.Property<DateTime>("ShippedDate");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AlperleGrubum.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Discount");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<short>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("AlperleGrubum.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("Discontinued");

                    b.Property<int?>("OrderDetailId");

                    b.Property<int>("OrderId");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<short>("ReorderLevel");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<short>("UnitsInStock");

                    b.Property<short>("UnitsOnOrder");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AlperleGrubum.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("HomePage");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("ProductId");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("AlperleGrubum.Models.Category", b =>
                {
                    b.HasOne("AlperleGrubum.Models.Product", "Product")
                        .WithMany("Categories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlperleGrubum.Models.Order", b =>
                {
                    b.HasOne("AlperleGrubum.Models.OrderDetail", "OrderDetail")
                        .WithMany("Orders")
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlperleGrubum.Models.Product", b =>
                {
                    b.HasOne("AlperleGrubum.Models.OrderDetail", "OrderDetail")
                        .WithMany("Products")
                        .HasForeignKey("OrderDetailId");
                });

            modelBuilder.Entity("AlperleGrubum.Models.Supplier", b =>
                {
                    b.HasOne("AlperleGrubum.Models.Product", "Product")
                        .WithMany("Supplier")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
