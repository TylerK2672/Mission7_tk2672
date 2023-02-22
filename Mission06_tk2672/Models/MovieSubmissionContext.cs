using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_tk2672.Models
{
    public class MovieSubmissionContext : DbContext
    {
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, CategoryName="Action"},
                new Category { CategoryId=2, CategoryName="Adventure"},
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Romance" }
            );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    CategoryId = 2,
                    Title = "Interstellar",
                    Year = "2014",
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Joe",
                    Notes = "None"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryId = 1,
                    Title = "Fury",
                    Year = "2014",
                    Director = "David Ayer",
                    Rating = "R",
                    Edited = true,
                    LentTo = "Joe",
                    Notes = "Great film, but gruesome."
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryId = 2,
                    Title = "My Neighbor Totoro",
                    Year = "1988",
                    Director = "Hayao Miyazaki",
                    Rating = "G",
                    Edited = false,
                    LentTo = "Tim",
                    Notes = "Adorable movie"
                }
            );
        }
    }
}
