using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using LeapYears.Data;
using LeapYears.Interfaces;
using LeapYears.DTO;

namespace LeapYears.Pages
{
    public class IndexModel : PageModel
    {       
        private readonly ILogger<IndexModel> _logger;

        // -- Wstrzykiwanie serwisów
        private readonly IHistoryService _historyService;
        public ListHistoryDTO records { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHistoryService historyService)
        {
            _logger = logger;
            _historyService = historyService;
        }

        public void OnGet()
        {
            records = _historyService.GetHistoryToList(true);

        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {

               
            }

            return Page();
        }

    }
}
