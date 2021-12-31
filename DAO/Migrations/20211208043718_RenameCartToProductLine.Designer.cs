﻿// <auto-generated />
using System;
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20211208043718_RenameCartToProductLine")]
    partial class RenameCartToProductLine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("DAO.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Apartment")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("House")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalOffice")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DAO.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("SecondName")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("UserName")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("DAO.Models.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DAO.Models.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("AuthorId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Content")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DAO.Models.LikeJunction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("LikeJunctions");
                });

            modelBuilder.Entity("DAO.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("CartId")
                        .HasColumnType("bigint");

                    b.Property<string>("Comment")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CostumerId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("GiftWrap")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("CostumerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DAO.Models.ProductLine", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<long>("CartId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLines");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ValueEn")
                        .HasColumnType("longtext");

                    b.Property<string>("ValueRu")
                        .HasColumnType("longtext");

                    b.Property<string>("ValueUk")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long?>("ProductInfoId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProductInfoId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductInfoId");

                    b.HasIndex("ProductInfoId1");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<string>("AppUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("NavCategoryFirstLvlId")
                        .HasColumnType("int");

                    b.Property<int?>("NavCategorySecondLvlId")
                        .HasColumnType("int");

                    b.Property<long>("Popularity")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PriceUsd")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("NavCategoryFirstLvlId");

                    b.HasIndex("NavCategorySecondLvlId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.ProductInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Lang")
                        .HasColumnType("int");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int?>("ShortDescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShortDescriptionId");

                    b.ToTable("ProductInfos");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.ProductIngredientsTableRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("FirstColumn")
                        .HasColumnType("longtext");

                    b.Property<long?>("ProductInfoId")
                        .HasColumnType("bigint");

                    b.Property<string>("SecondColumn")
                        .HasColumnType("longtext");

                    b.Property<string>("ThirdColumn")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductInfoId");

                    b.ToTable("ProductIngredientsTableRows");
                });

            modelBuilder.Entity("DAO.Models.AppUser", b =>
                {
                    b.HasOne("DAO.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DAO.Models.Comment", b =>
                {
                    b.HasOne("DAO.Models.AppUser", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId");

                    b.HasOne("DAO.Models.ProductModel.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAO.Models.LikeJunction", b =>
                {
                    b.HasOne("DAO.Models.ProductModel.Product", "Product")
                        .WithMany("LikeJunction")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAO.Models.Order", b =>
                {
                    b.HasOne("DAO.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAO.Models.AppUser", "Costumer")
                        .WithMany()
                        .HasForeignKey("CostumerId");

                    b.Navigation("Cart");

                    b.Navigation("Costumer");
                });

            modelBuilder.Entity("DAO.Models.ProductLine", b =>
                {
                    b.HasOne("DAO.Models.Cart", null)
                        .WithMany("CartLines")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAO.Models.ProductModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.Description", b =>
                {
                    b.HasOne("DAO.Models.ProductModel.ProductInfo", null)
                        .WithMany("DescriptionsLi")
                        .HasForeignKey("ProductInfoId");

                    b.HasOne("DAO.Models.ProductModel.ProductInfo", null)
                        .WithMany("DopDescriptions")
                        .HasForeignKey("ProductInfoId1");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.Product", b =>
                {
                    b.HasOne("DAO.Models.AppUser", null)
                        .WithMany("Likes")
                        .HasForeignKey("AppUserId");

                    b.HasOne("DAO.Models.ProductModel.Category", "NavCategoryFirstLvl")
                        .WithMany()
                        .HasForeignKey("NavCategoryFirstLvlId");

                    b.HasOne("DAO.Models.ProductModel.Category", "NavCategorySecondLvl")
                        .WithMany()
                        .HasForeignKey("NavCategorySecondLvlId");

                    b.Navigation("NavCategoryFirstLvl");

                    b.Navigation("NavCategorySecondLvl");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.ProductInfo", b =>
                {
                    b.HasOne("DAO.Models.ProductModel.Product", null)
                        .WithMany("ProductInfos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAO.Models.ProductModel.Description", "ShortDescription")
                        .WithMany()
                        .HasForeignKey("ShortDescriptionId");

                    b.Navigation("ShortDescription");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.ProductIngredientsTableRow", b =>
                {
                    b.HasOne("DAO.Models.ProductModel.ProductInfo", null)
                        .WithMany("Table")
                        .HasForeignKey("ProductInfoId");
                });

            modelBuilder.Entity("DAO.Models.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("DAO.Models.Cart", b =>
                {
                    b.Navigation("CartLines");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("LikeJunction");

                    b.Navigation("ProductInfos");
                });

            modelBuilder.Entity("DAO.Models.ProductModel.ProductInfo", b =>
                {
                    b.Navigation("DescriptionsLi");

                    b.Navigation("DopDescriptions");

                    b.Navigation("Table");
                });
#pragma warning restore 612, 618
        }
    }
}
