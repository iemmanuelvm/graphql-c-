﻿// <auto-generated />
using GraphqlProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GraphqlProject.Migrations
{
    [DbContext(typeof(GraphQLDbContext))]
    [Migration("20240518182011_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GraphqlProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://example.com/categories/appetizers.jpg",
                            Name = "Appetizers"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://example.com/categories/main-course.jpg",
                            Name = "Main Course"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://example.com/categories/desserts.jpg",
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("GraphqlProject.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Spicy chicken wings served with blue cheese dip.",
                            ImageUrl = "https://example.com/menus/chicken-wings.jpg",
                            Name = "Chicken Wings",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Grilled steak with mashed potatoes and vegetables.",
                            ImageUrl = "https://example.com/menus/steak.jpg",
                            Name = "Steak",
                            Price = 24.5
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Decadent chocolate cake with a scoop of vanilla ice cream.",
                            ImageUrl = "https://example.com/menus/chocolate-cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 6.9500000000000002
                        });
                });

            modelBuilder.Entity("GraphqlProject.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PartySize")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReservationDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SpecialRequest")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "John Doe",
                            Email = "johndoe@example.com",
                            PartySize = 2,
                            PhoneNumber = "555-123-4567",
                            ReservationDate = "17/09/2025",
                            SpecialRequest = "No nuts in the dishes, please."
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Jane Smith",
                            Email = "janesmith@example.com",
                            PartySize = 4,
                            PhoneNumber = "555-987-6543",
                            ReservationDate = "10/11/2025",
                            SpecialRequest = "Gluten-free options required."
                        },
                        new
                        {
                            Id = 3,
                            CustomerName = "Michael Johnson",
                            Email = "michaeljohnson@example.com",
                            PartySize = 6,
                            PhoneNumber = "555-789-0123",
                            ReservationDate = "09/12/2025",
                            SpecialRequest = "Celebrating a birthday."
                        });
                });

            modelBuilder.Entity("GraphqlProject.Models.Menu", b =>
                {
                    b.HasOne("GraphqlProject.Models.Category", null)
                        .WithMany("Menus")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GraphqlProject.Models.Category", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
