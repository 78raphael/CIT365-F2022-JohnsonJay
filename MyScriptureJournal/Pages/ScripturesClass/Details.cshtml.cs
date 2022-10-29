using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.ScripturesClass
{
    public class DetailsModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public DetailsModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

      public ScriptureClass ScriptureClass { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ScriptureClass == null)
            {
                return NotFound();
            }

            var scriptureclass = await _context.ScriptureClass.FirstOrDefaultAsync(m => m.ID == id);
            if (scriptureclass == null)
            {
                return NotFound();
            }
            else 
            {
                ScriptureClass = scriptureclass;
            }
            return Page();
        }
    }
}
