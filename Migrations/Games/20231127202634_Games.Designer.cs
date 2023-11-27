﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSAD_Final_Project.Models;

#nullable disable

namespace WSAD_Final_Project.Migrations.Games
{
    [DbContext(typeof(GamesContext))]
    [Migration("20231127202634_Games")]
    partial class Games
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WSAD_Final_Project.Models.Videogames", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Developer = "Sega",
                            ReleaseYear = 2022,
                            Title = "Sonic Frontiers"
                        },
                        new
                        {
                            GameId = 2,
                            Developer = "Sora Ltd.",
                            ReleaseYear = 2017,
                            Title = "Super Smash Bros. Ultimate"
                        },
                        new
                        {
                            GameId = 3,
                            Developer = "Sora Ltd.",
                            ReleaseYear = 2014,
                            Title = "Super Smash Bros. Wii U"
                        },
                        new
                        {
                            GameId = 4,
                            Developer = "Nintendo",
                            ReleaseYear = 2017,
                            Title = "Mario Kart 8 Deluxe"
                        },
                        new
                        {
                            GameId = 5,
                            Developer = "Nintendo",
                            ReleaseYear = 2010,
                            Title = "Sonic Colors"
                        },
                        new
                        {
                            GameId = 6,
                            Developer = "Microsoft",
                            ReleaseYear = 2012,
                            Title = "Halo 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}