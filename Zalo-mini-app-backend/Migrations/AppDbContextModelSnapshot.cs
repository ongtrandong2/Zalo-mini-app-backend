﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Zalo_mini_app_backend;

#nullable disable

namespace Zalo_mini_app_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Zalo_mini_app_backend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "P001",
                            ImageUrl = "https://placehold.co/100x100",
                            Name = "Product 1",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            Code = "P002",
                            ImageUrl = "https://placehold.co/100x100",
                            Name = "Product 2",
                            Price = 150m
                        },
                        new
                        {
                            Id = 3,
                            Code = "P003",
                            ImageUrl = "https://placehold.co/100x100",
                            Name = "Product 3",
                            Price = 200m
                        },
                        new
                        {
                            Id = 4,
                            Code = "P004",
                            ImageUrl = "https://placehold.co/100x100",
                            Name = "Product 4",
                            Price = 250m
                        },
                        new
                        {
                            Id = 5,
                            Code = "P005",
                            ImageUrl = "https://placehold.co/100x100",
                            Name = "Product 5",
                            Price = 300m
                        },
                        new
                        {
                            Id = 6,
                            Code = "P006",
                            ImageUrl = "https://placehold.co/100x100",
                            Name = "Product 6",
                            Price = 25000m
                        });
                });

            modelBuilder.Entity("Zalo_mini_app_backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AvtUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvtUrl = "https://placehold.co/100x100",
                            Name = "ABC",
                            PhoneNumber = "0983827050"
                        },
                        new
                        {
                            Id = 2,
                            AvtUrl = "https://placehold.co/100x100",
                            Name = "DEF",
                            PhoneNumber = "0983827051"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
