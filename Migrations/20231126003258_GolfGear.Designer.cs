﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSAD_Final_Project.Models;

#nullable disable

namespace WSAD_Final_Project.Migrations
{
    [DbContext(typeof(HobbyContext))]
    [Migration("20231126003258_GolfGear")]
    partial class GolfGear
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WSAD_Final_Project.Models.GolfGear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("golfGears");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Callaway",
                            Name = "Paradym",
                            Type = "Driver"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Taylormade",
                            Name = "Stealth 2",
                            Type = "Driver"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Titleist",
                            Name = "Vokey",
                            Type = "Wedge"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Ping",
                            Name = "G425",
                            Type = "Irons"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Taylormade",
                            Name = "Spider",
                            Type = "Putter"
                        });
                });

            modelBuilder.Entity("WSAD_Final_Project.Models.SnowboardGear", b =>
                {
                    b.Property<int>("GearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GearId"));

                    b.Property<int?>("Brand")
                        .HasColumnType("int");

                    b.Property<int?>("GearType")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GearId");

                    b.ToTable("SnowboardGear");

                    b.HasData(
                        new
                        {
                            GearId = 1,
                            Brand = 0,
                            GearType = 0,
                            Model = "Custom"
                        },
                        new
                        {
                            GearId = 2,
                            Brand = 8,
                            GearType = 1,
                            Model = "Force"
                        },
                        new
                        {
                            GearId = 3,
                            Brand = 9,
                            GearType = 2,
                            Model = "Hi-Standard"
                        },
                        new
                        {
                            GearId = 4,
                            Brand = 10,
                            GearType = 3,
                            Model = "Snow Shell"
                        },
                        new
                        {
                            GearId = 5,
                            Brand = 11,
                            GearType = 5,
                            Model = "I/O Mag"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
