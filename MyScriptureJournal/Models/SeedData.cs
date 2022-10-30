using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.ScriptureClass.Any())
                {
                    return;   // DB has been seeded
                }

                context.ScriptureClass.AddRange(
                    new ScriptureClass
                    { 
                        DateAdded = DateTime.Parse("2022-2-12"),
                        Book = "Nephi",
                        Chapter = 1,
                        Verse = 1,
                        Note = "This is the most read verse in the entire BOM."
                    },

                    new ScriptureClass
                    {
                        DateAdded = DateTime.Parse("2022-10-29"),
                        Book = "Alma",
                        Chapter = 1,
                        Verse = 1,
                        Note = "This verse changed my life."
                    },

                    new ScriptureClass
                    {
                        DateAdded = DateTime.Parse("2022-8-16"),
                        Book = "Genesis",
                        Chapter = 1,
                        Verse = 1,
                        Note = "This is where it all started."
                    },

                    new ScriptureClass
                    {
                        DateAdded = DateTime.Parse("2022-10-28"),
                        Book = "Revelation",
                        Chapter = 1,
                        Verse = 1,
                        Note = "This is the beginning of the end."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}