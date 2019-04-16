﻿// <auto-generated />
using Assignment4Games.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment4Games.Migrations
{
    [DbContext(typeof(Assignment4GamesContext))]
    [Migration("20181129165311_addedReveiew")]
    partial class addedReveiew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment4Games.Models.Game", b =>
                {
                    b.Property<string>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Developer");

                    b.Property<string>("GameName");

                    b.Property<string>("Genre");

                    b.Property<string>("Languages");

                    b.Property<string>("Platform");

                    b.Property<int>("Rating");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Assignment4Games.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<string>("GameId");

                    b.Property<string>("UserName");

                    b.HasKey("ReviewId");

                    b.ToTable("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
