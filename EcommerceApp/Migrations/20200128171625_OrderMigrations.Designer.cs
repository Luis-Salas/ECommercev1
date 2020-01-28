﻿// <auto-generated />
using System;
using EcommerceApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EcommerceApp.Migrations
{
    [DbContext(typeof(HomeContext))]
    [Migration("20200128171625_OrderMigrations")]
    partial class OrderMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EcommerceApp.Models.Design", b =>
                {
                    b.Property<int>("DesignId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Image");

                    b.Property<int>("PromoTime");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("DesignId");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("EcommerceApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("orderNumber");

                    b.Property<string>("status");

                    b.Property<int>("total");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EcommerceApp.Models.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.Property<string>("about")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("PageId");

                    b.HasIndex("UserId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("EcommerceApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("DesignId");

                    b.Property<int>("OrderId");

                    b.Property<int>("PageId");

                    b.Property<string>("ProductColor");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName");

                    b.Property<int>("ProductQuantity");

                    b.Property<string>("ProductSize");

                    b.Property<string>("ProductStyle");

                    b.Property<string>("Testimonial");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ProductId");

                    b.HasIndex("DesignId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PageId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EcommerceApp.Models.ProductStyle", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("StyleId");

                    b.HasKey("ProductId", "StyleId");

                    b.HasIndex("StyleId");

                    b.ToTable("ProductStyles");
                });

            modelBuilder.Entity("EcommerceApp.Models.Style", b =>
                {
                    b.Property<int>("StyleId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("StyleId");

                    b.ToTable("Styles");
                });

            modelBuilder.Entity("EcommerceApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EcommerceApp.Models.Page", b =>
                {
                    b.HasOne("EcommerceApp.Models.User", "UsersPage")
                        .WithMany("Pages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EcommerceApp.Models.Product", b =>
                {
                    b.HasOne("EcommerceApp.Models.Design", "design")
                        .WithMany("ParentProduct")
                        .HasForeignKey("DesignId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EcommerceApp.Models.Order", "LinkToOrderObject")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EcommerceApp.Models.Page", "ProductsPage")
                        .WithMany("Products")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EcommerceApp.Models.ProductStyle", b =>
                {
                    b.HasOne("EcommerceApp.Models.Product", "Product")
                        .WithMany("ProductsStyles")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EcommerceApp.Models.Style", "Style")
                        .WithMany("BaseProduct")
                        .HasForeignKey("StyleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
