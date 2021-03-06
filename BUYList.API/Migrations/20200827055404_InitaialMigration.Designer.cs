﻿// <auto-generated />
using System;
using BUYList.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BUYList.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200827055404_InitaialMigration")]
    partial class InitaialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BUYList.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67d86d59-84c7-4939-a81d-10d59c6fe4f5"),
                            CreateDate = new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a Toradora volume 8 in Amazon.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Toradora",
                            UserId = new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732")
                        },
                        new
                        {
                            Id = new Guid("99673a66-bb5d-41f7-8a2f-09485afc0ccb"),
                            CreateDate = new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a Re: Zero volume 13 in Amazon.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Re: Zero",
                            UserId = new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732")
                        },
                        new
                        {
                            Id = new Guid("530b86d0-8ea3-4e11-87a6-5719af3348fa"),
                            CreateDate = new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a Re: Zero volume 12 in Amazon.",
                            IsActive = false,
                            IsDeleted = true,
                            Name = "Re: Zero",
                            UserId = new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732")
                        },
                        new
                        {
                            Id = new Guid("de1cc9e3-6c52-46a5-8ce2-173da2015bf4"),
                            CreateDate = new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a Car in WebMotors.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Car",
                            UserId = new Guid("95ae172e-1e77-4df6-993c-2b20302c6e02")
                        },
                        new
                        {
                            Id = new Guid("4a6807d9-5eb4-4b0e-98e6-5fc661822bb0"),
                            CreateDate = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a TV in Amazon.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "TV",
                            UserId = new Guid("95ae172e-1e77-4df6-993c-2b20302c6e02")
                        },
                        new
                        {
                            Id = new Guid("48234769-8826-43d0-97ce-5579daf7cb0b"),
                            CreateDate = new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a Mouse in Razer.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Mouse",
                            UserId = new Guid("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35")
                        },
                        new
                        {
                            Id = new Guid("a1a4793b-874c-43d4-80d4-fd71097aec9d"),
                            CreateDate = new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Buy a Mousepad in Razer.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Mousepad",
                            UserId = new Guid("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35")
                        });
                });

            modelBuilder.Entity("BUYList.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd080e3b-1d46-4c48-bf27-adc079f36732"),
                            Email = "pedrooctavio@email.com",
                            IsDeleted = false,
                            Name = "Pedro Octávio",
                            Password = "pedropassword"
                        },
                        new
                        {
                            Id = new Guid("95ae172e-1e77-4df6-993c-2b20302c6e02"),
                            Email = "igorandrade@email.com",
                            IsDeleted = false,
                            Name = "Ígor Andrade",
                            Password = "igorpassword"
                        },
                        new
                        {
                            Id = new Guid("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35"),
                            Email = "juliasilva@email.com",
                            IsDeleted = false,
                            Name = "Júlia da Silva",
                            Password = "juliapassword"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
