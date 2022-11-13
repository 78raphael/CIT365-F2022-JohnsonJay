using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Brigham City",
                    ReleaseDate = DateTime.Parse("2001-3-30"),
                    Genre = "Drama",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Once I Was A Beehive",
                    ReleaseDate = DateTime.Parse("2015-8-14"),
                    Genre = "Comedy",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "The Singles Ward",
                    ReleaseDate = DateTime.Parse("2002-1-30"),
                    Genre = "RomCom",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "The Work & The Glory",
                    ReleaseDate = DateTime.Parse("2005-1-21"),
                    Genre = "Drama",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}