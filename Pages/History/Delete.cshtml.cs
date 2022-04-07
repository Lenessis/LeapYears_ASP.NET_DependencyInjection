using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeapYears.Data;
using LeapYears.Models;

namespace LeapYears.Pages.History
{
    public class DeleteModel : PageModel
    {
        private readonly LeapYears.Data.ContextDB _context;

        public DeleteModel(LeapYears.Data.ContextDB context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.History History { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            History = await _context.History
                .Include(h => h.YearUser).FirstOrDefaultAsync(m => m.Id == id);

            if (History == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            History = await _context.History.FindAsync(id);

            if (History != null)
            {
                _context.History.Remove(History);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
