using LeapYears.Data;
using LeapYears.Interfaces;
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

        private readonly IPersonService _personService;

        private readonly ILogger<AddingPersonModel> _logger;

        public AddingPersonModel(ILogger<AddingPersonModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                ViewData["extraY"] = user.year;
                ViewData["user"] = user.name;
                extra = user.ExtraYear();
                gender = user.Gender();
                hide = false;

                _personService.AddNewPerson(user);
            }

            return Page();
        }
    }
}
