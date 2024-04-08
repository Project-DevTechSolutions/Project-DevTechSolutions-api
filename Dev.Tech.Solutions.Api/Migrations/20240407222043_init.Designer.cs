﻿// <auto-generated />
using System;
using Dev.Tech.Solutions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dev.Tech.Solutions.Api.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20240407222043_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Dev.Tech.Solutions.Domain.Catalog.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Nike",
                            Description = "Ohio State Shirt",
                            Name = "Shirt",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Nike",
                            Description = "Ohio State shorts",
                            Name = "Shorts",
                            Price = 44.99m
                        });
                });

            modelBuilder.Entity("Dev.Tech.Solutions.Domain.Catalog.Rating", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Ratingid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("ItemId");

                    b.HasIndex("Ratingid");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Dev.Tech.Solutions.Domain.Catalog.Rating", b =>
                {
                    b.HasOne("Dev.Tech.Solutions.Domain.Catalog.Item", null)
                        .WithMany("Ratings")
                        .HasForeignKey("ItemId");

                    b.HasOne("Dev.Tech.Solutions.Domain.Catalog.Rating", null)
                        .WithMany("Ratings")
                        .HasForeignKey("Ratingid");
                });

            modelBuilder.Entity("Dev.Tech.Solutions.Domain.Catalog.Item", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Dev.Tech.Solutions.Domain.Catalog.Rating", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
