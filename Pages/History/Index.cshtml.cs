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
using LeapYears.DTO;
using LeapYears.Interfaces;

namespace LeapYears.Pages.History
{
    public class IndexModel : PageModel
    {

        public ListHistoryDTO records { get; set; }
        private readonly IHistoryService _historyService;

        public IndexModel(LeapYears.Data.ContextDB context, IHistoryService historyService)
        {
            _historyService = historyService;
        }

        public IList<Models.HistoryUser> History { get;set; }

        public async Task OnGetAsync()
        {

            records = _historyService.GetLimitedHistoryToList();
        }
    }
}
