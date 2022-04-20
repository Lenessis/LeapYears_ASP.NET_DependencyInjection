using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeapYears.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LeapYears.Pages
{
    public class YearBaseModel : PageModel
    {

        public List<YearUser> listDB = new List<YearUser>();
        [BindProperty(SupportsGet =true)]
        public string user { get; set; }

        private readonly ILogger<YearBaseModel> _logger;
        private readonly ContextDB _context; // -- context bazy danych 

        public YearBaseModel(ILogger<YearBaseModel> logger, ContextDB context)
        {
            _logger = logger;
            _context = context;
        }

        //dodac ostatnio szukane

        /*
         * Wyszukiwanie
         * Tutorial: https://www.youtube.com/watch?v=gb6TMtoGQEM
         */

        public void OnGet()
        {
            if (string.IsNullOrEmpty(user))
                listDB = _context.User.OrderBy(p => p.name).ToList();
            else
            {
                listDB = _context.User.Where(p => p.name.Contains(user) || p.lastname.Contains(user)).OrderBy(p => p.name).ToList();
               
                foreach (var item in listDB)
                {
                    _context.History.Add(item.AddView(user));
                    _context.SaveChanges();
                }
                
            }
                
        }


    }
}
