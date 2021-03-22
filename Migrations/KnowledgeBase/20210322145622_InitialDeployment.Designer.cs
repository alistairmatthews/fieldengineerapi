﻿// <auto-generated />
using FieldEngineerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FieldEngineerApi.Migrations.KnowledgeBase
{
    [DbContext(typeof(KnowledgeBaseContext))]
    [Migration("20210322145622_InitialDeployment")]
    partial class InitialDeployment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FieldEngineerApi.Models.KnowledgeBaseBoilerPart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoilerParts");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Caserta Stone Beige",
                            Overview = "Extreme Series 18 in. x 18 in. carpet tiles are a durable and beautiful carpet solution specially engineered for both indoor and outdoor residential installations."
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Caserta Sky Grey",
                            Overview = "Extreme Series 18 in. x 18 in. carpet tiles are a durable and beautiful carpet solution specially engineered for both indoor and outdoor residential installations."
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Ageless Beauty Clay",
                            Overview = "Add some fashion to your floors with the Shaw Ageless Beauty Carpet collection."
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Lush II Tundra",
                            Overview = "Made with 100% premium nylon fiber, this textured carpet creates a warm, casual atmosphere that invites you to relax and thoroughly enjoy your home."
                        });
                });

            modelBuilder.Entity("FieldEngineerApi.Models.KnowledgeBaseEngineer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Engineers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ContactNumber = "554-1000",
                            Name = "Sara Perez"
                        },
                        new
                        {
                            Id = 2L,
                            ContactNumber = "554-1001",
                            Name = "Michelle Harris"
                        },
                        new
                        {
                            Id = 3L,
                            ContactNumber = "554-1002",
                            Name = "Quincy Watson"
                        });
                });

            modelBuilder.Entity("FieldEngineerApi.Models.KnowledgeBaseTip", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("KnowledgeBaseBoilerPartId")
                        .HasColumnType("bigint");

                    b.Property<long>("KnowledgeBaseEngineerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KnowledgeBaseBoilerPartId");

                    b.HasIndex("KnowledgeBaseEngineerId");

                    b.ToTable("Tips");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Body = "If water doesn't get hot when radiators are on, replace the diverter valve.",
                            KnowledgeBaseBoilerPartId = 1L,
                            KnowledgeBaseEngineerId = 3L,
                            Subject = "How to get water to the right temperature"
                        },
                        new
                        {
                            Id = 2L,
                            Body = "When installing this unit, don't place it more that 5 feet higher than the fuel tank, without a fuel pump.",
                            KnowledgeBaseBoilerPartId = 1L,
                            KnowledgeBaseEngineerId = 3L,
                            Subject = "Where to site this boiler"
                        },
                        new
                        {
                            Id = 3L,
                            Body = "Sometimes the nozzle gets clogged with old oil or dirt. You can use a fine point to clear it, or replace.",
                            KnowledgeBaseBoilerPartId = 3L,
                            KnowledgeBaseEngineerId = 1L,
                            Subject = "How to get this nozzle to light the furnace correctly"
                        });
                });

            modelBuilder.Entity("FieldEngineerApi.Models.KnowledgeBaseTip", b =>
                {
                    b.HasOne("FieldEngineerApi.Models.KnowledgeBaseBoilerPart", "KnowledgeBaseBoilerPart")
                        .WithMany("KnowledgeBaseTips")
                        .HasForeignKey("KnowledgeBaseBoilerPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FieldEngineerApi.Models.KnowledgeBaseEngineer", "KnowledgeBaseEngineer")
                        .WithMany("KnowledgeBaseTips")
                        .HasForeignKey("KnowledgeBaseEngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KnowledgeBaseBoilerPart");

                    b.Navigation("KnowledgeBaseEngineer");
                });

            modelBuilder.Entity("FieldEngineerApi.Models.KnowledgeBaseBoilerPart", b =>
                {
                    b.Navigation("KnowledgeBaseTips");
                });

            modelBuilder.Entity("FieldEngineerApi.Models.KnowledgeBaseEngineer", b =>
                {
                    b.Navigation("KnowledgeBaseTips");
                });
#pragma warning restore 612, 618
        }
    }
}
