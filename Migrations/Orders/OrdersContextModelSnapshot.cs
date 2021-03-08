﻿// <auto-generated />
using FieldEngineerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FieldEngineerApi.Migrations.Orders
{
    [DbContext(typeof(OrdersContext))]
    partial class OrdersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ContainedInId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("BoilerPart");
                });

            modelBuilder.Entity("FieldEngineerApi.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BoilerPartId")
                        .HasColumnType("bigint");

                    b.Property<string>("BoilerPartName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.Property<long>("quantity")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BoilerPartId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FieldEngineerApi.Models.Order", b =>
                {
                    b.HasOne("FieldEngineerApi.Models.BoilerPart", "BoilerPart")
                        .WithMany()
                        .HasForeignKey("BoilerPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoilerPart");
                });
#pragma warning restore 612, 618
        }
    }
}
