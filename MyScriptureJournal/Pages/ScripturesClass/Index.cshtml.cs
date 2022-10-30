using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.ScripturesClass
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;
        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<ScriptureClass> ScriptureClass { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList BookList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        public string DateSort { get; set; }
        public string BookSort { get; set; }
/*        public string ChapterSort { get; set; }
        public string VerseSort { get; set; }*/

        public async Task OnGetAsync( string sortOrder )
        {
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from m in _context.ScriptureClass
                                            orderby m.Book
                                            select m.Book;

            var books = from m in _context.ScriptureClass
                        select m;

            switch (sortOrder)
            {
                case "name_desc":
                    books = books.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    books = books.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    books = books.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    books = books.OrderBy(s => s.Book);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Book.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                books = books.Where(x => x.Book == ScriptureBook);
            }
            BookList = new SelectList(await bookQuery.Distinct().ToListAsync());
            /*ScriptureClass = books.AsNoTracking().ToListAsync();*/
            ScriptureClass = await books.AsNoTracking().ToListAsync();
        }
    }
}
