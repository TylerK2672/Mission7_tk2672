﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_tk2672.Models;

namespace Mission06_tk2672.Migrations
{
    [DbContext(typeof(MovieSubmissionContext))]
    partial class MovieSubmissionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Mission06_tk2672.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 2,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "Joe",
                            Notes = "None",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = "2014"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 1,
                            Director = "David Ayer",
                            Edited = true,
                            LentTo = "Joe",
                            Notes = "Great film, but gruesome.",
                            Rating = "R",
                            Title = "Fury",
                            Year = "2014"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 2,
                            Director = "Hayao Miyazaki",
                            Edited = false,
                            LentTo = "Tim",
                            Notes = "Adorable movie",
                            Rating = "G",
                            Title = "My Neighbor Totoro",
                            Year = "1988"
                        });
                });

            modelBuilder.Entity("Mission06_tk2672.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Romance"
                        });
                });

            modelBuilder.Entity("Mission06_tk2672.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission06_tk2672.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
