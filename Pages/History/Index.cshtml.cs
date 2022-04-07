using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeapYears.Data;
using LeapYears.Models;
using LeapYears.Pages;

namespace LeapYears.Pages.History
{
    public class IndexModel : PageModel
    {
        private readonly LeapYears.Data.ContextDB _context;

        public IndexModel(LeapYears.Data.ContextDB context)
        {
            _context = context;
        }

        public IList<Models.History> History { get;set; }

        public async Task OnGetAsync()
        {
            History = await _context.History
                .Include(h => h.YearUser).ToListAsync();
        }
    }
}
