﻿// <auto-generated />
using System;
using FieldEngineerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FieldEngineerApi.Migrations.Inventory
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20210317140822_NullableDateColumn")]
    partial class NullableDateColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FieldEngineerApi.Models.BoilerPart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberInStock")
                        .HasColumnType("int");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("BoilerParts");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = "PCB Assembly",
                            ImageUrl = "http://contoso.com/image1",
                            Name = "Pumped Water Controller",
                            NumberInStock = 0,
                            Overview = "Water pump controller for combination boiler",
                            Price = 45.99m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = "Heat Exchanger",
                            ImageUrl = "http://contoso.com/image2",
                            Name = "3.5 W/S Heater",
                            NumberInStock = 5,
                            Overview = "Small heat exchanger for domestic boiler",
                            Price = 125.5m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = "Valve",
                            ImageUrl = "http://contoso.com/image3",
                            Name = "Inlet Valve",
                            NumberInStock = 13,
                            Overview = "Water inlet valve with one-way operation",
                            Price = 120.2m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = "Valve",
                            ImageUrl = "http://contoso.com/image4",
                            Name = "Mid-position Valve",
                            NumberInStock = 8,
                            Overview = "Bi-directional pressure release",
                            Price = 180.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = "Heat Exchanger",
                            ImageUrl = "http://contoso.com/image5",
                            Name = "5.0 W/S Heater",
                            NumberInStock = 1,
                            Overview = "Medium heat exchanger for canteen boiler",
                            Price = 145.9m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryId = "PCB Assembly",
                            ImageUrl = "http://contoso.com/image6",
                            Name = "Fan Controller",
                            NumberInStock = 7,
                            Overview = "Controller for air-con unit",
                            Price = 28.35m
                        });
                });

            modelBuilder.Entity("FieldEngineerApi.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BoilerPartId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Delivered")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeliveredDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.Property<long>("quantity")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BoilerPartId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BoilerPartId = 1L,
                            Delivered = false,
                            OrderedDateTime = new DateTime(2021, 3, 12, 14, 8, 22, 115, DateTimeKind.Local).AddTicks(5148),
                            TotalPrice = 243.0m,
                            quantity = 30L
                        },
                        new
                        {
                            Id = 2L,
                            BoilerPartId = 3L,
                            Delivered = true,
                            DeliveredDateTime = new DateTime(2021, 3, 13, 14, 8, 22, 118, DateTimeKind.Local).AddTicks(1383),
                            OrderedDateTime = new DateTime(2021, 3, 10, 14, 8, 22, 118, DateTimeKind.Local).AddTicks(1359),
                            TotalPrice = 39.6m,
                            quantity = 20L
                        });
                });

            modelBuilder.Entity("FieldEngineerApi.Models.Order", b =>
                {
                    b.HasOne("FieldEngineerApi.Models.BoilerPart", "BoilerPart")
                        .WithMany("Orders")
                        .HasForeignKey("BoilerPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoilerPart");
                });

            modelBuilder.Entity("FieldEngineerApi.Models.BoilerPart", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
