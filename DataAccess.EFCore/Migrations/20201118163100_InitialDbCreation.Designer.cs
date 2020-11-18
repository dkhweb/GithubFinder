﻿// <auto-generated />
using System;
using DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.EFCore.Migrations
{
    [DbContext(typeof(PlutoContext))]
    [Migration("20201118163100_InitialDbCreation")]
    partial class InitialDbCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.EFCore.Models.Repo", b =>
                {
                    b.Property<int>("RepoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForksCount")
                        .HasColumnType("int");

                    b.Property<string>("HtmlUrl")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("StargazersCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RepoId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Repos");
                });

            modelBuilder.Entity("DataAccess.EFCore.Models.RepoOwner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("OwnerId");

                    b.ToTable("RepoOwners");
                });

            modelBuilder.Entity("DataAccess.EFCore.Models.Repo", b =>
                {
                    b.HasOne("DataAccess.EFCore.Models.RepoOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
