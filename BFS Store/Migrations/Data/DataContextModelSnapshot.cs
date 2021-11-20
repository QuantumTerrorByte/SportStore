﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportStore.Models.DAO;

namespace SportStore.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("SportStore.Models.Core.CartLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLines");
                });

            modelBuilder.Entity("SportStore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("GiftWrap")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ValueEn")
                        .HasColumnType("text");

                    b.Property<string>("ValueRu")
                        .HasColumnType("text");

                    b.Property<string>("ValueUk")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long?>("ProductInfoId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProductInfoId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductInfoId");

                    b.HasIndex("ProductInfoId1");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("NavCategoryFirstLvlId")
                        .HasColumnType("int");

                    b.Property<int?>("NavCategorySecondLvlId")
                        .HasColumnType("int");

                    b.Property<long>("Popularity")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PriceUsd")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("NavCategoryFirstLvlId");

                    b.HasIndex("NavCategorySecondLvlId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.ProductInfo", b =>
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

            modelBuilder.Entity("SportStore.Models.ProductModel.ProductIngredientsTableRow", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("FirstColumn")
                        .HasColumnType("text");

                    b.Property<long?>("ProductInfoId")
                        .HasColumnType("bigint");

                    b.Property<string>("SecondColumn")
                        .HasColumnType("text");

                    b.Property<string>("ThirdColumn")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductInfoId");

                    b.ToTable("ProductIngredientsTableRow");
                });

            modelBuilder.Entity("SportStore.Models.Core.CartLine", b =>
                {
                    b.HasOne("SportStore.Models.Order", null)
                        .WithMany("CartLines")
                        .HasForeignKey("OrderId");

                    b.HasOne("SportStore.Models.ProductModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.Description", b =>
                {
                    b.HasOne("SportStore.Models.ProductModel.ProductInfo", null)
                        .WithMany("DescriptionsLi")
                        .HasForeignKey("ProductInfoId");

                    b.HasOne("SportStore.Models.ProductModel.ProductInfo", null)
                        .WithMany("DopDescriptions")
                        .HasForeignKey("ProductInfoId1");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.Product", b =>
                {
                    b.HasOne("SportStore.Models.ProductModel.Category", "NavCategoryFirstLvl")
                        .WithMany()
                        .HasForeignKey("NavCategoryFirstLvlId");

                    b.HasOne("SportStore.Models.ProductModel.Category", "NavCategorySecondLvl")
                        .WithMany()
                        .HasForeignKey("NavCategorySecondLvlId");

                    b.Navigation("NavCategoryFirstLvl");

                    b.Navigation("NavCategorySecondLvl");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.ProductInfo", b =>
                {
                    b.HasOne("SportStore.Models.ProductModel.Product", null)
                        .WithMany("ProductInfos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportStore.Models.ProductModel.Description", "ShortDescription")
                        .WithMany()
                        .HasForeignKey("ShortDescriptionId");

                    b.Navigation("ShortDescription");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.ProductIngredientsTableRow", b =>
                {
                    b.HasOne("SportStore.Models.ProductModel.ProductInfo", null)
                        .WithMany("Table")
                        .HasForeignKey("ProductInfoId");
                });

            modelBuilder.Entity("SportStore.Models.Order", b =>
                {
                    b.Navigation("CartLines");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.Product", b =>
                {
                    b.Navigation("ProductInfos");
                });

            modelBuilder.Entity("SportStore.Models.ProductModel.ProductInfo", b =>
                {
                    b.Navigation("DescriptionsLi");

                    b.Navigation("DopDescriptions");

                    b.Navigation("Table");
                });
#pragma warning restore 612, 618
        }
    }
}