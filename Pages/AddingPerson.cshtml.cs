using LeapYears.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LeapYears.Pages
{
    public class AddingPersonModel : PageModel
    {
        public bool extra, gender;
        public bool hide = true;

        [BindProperty]
        public YearUser user { get; set; }
        public List<YearUser> list = new List<YearUser>();
        public List<YearUser> listDB = new List<YearUser>();

        private readonly ILogger<AddingPersonModel> _logger;
        private readonly ContextDB _context; // -- context bazy danych 

        public AddingPersonModel(ILogger<AddingPersonModel> logger, ContextDB context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            listDB = _context.User.OrderBy(p => p.name).ToList();
        }

        public IActionResult OnPost()
        {
            listDB = _context.User.OrderBy(p => p.name).ToList();

            if (ModelState.IsValid)
            {
                ViewData["extraY"] = user.year;
                ViewData["user"] = user.name;
                extra = user.ExtraYear();
                gender = user.Gender();
                hide = false;



                _context.User.Add(user);
                _context.SaveChanges();

                //return RedirectToPage("./Index");
            }
            //return RedirectToPage("./Index"); // brak komunikat�w

            return Page();
        }
    }
}