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
    [Migration("20210311162200_Initial")]
    partial class Initial
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