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
    public class DetailsModel : PageModel
    {
        private readonly LeapYears.Data.ContextDB _context;

        public DetailsModel(LeapYears.Data.ContextDB context)
        {
            _context = context;
        }

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
    }
}
