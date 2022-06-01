using System.Collections.Generic;
using LeapYears.DTO;
using LeapYears.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LeapYears.Pages
{
    public class YearBaseModel : PageModel
    {
        public ListPersonDTO records { get; set; }

        [BindProperty(SupportsGet =true)]
        public string user { get; set; }

        private readonly ILogger<YearBaseModel> _logger;
        private readonly IPersonService _personService;
        private readonly IHistoryService _historyService;

        public YearBaseModel(ILogger<YearBaseModel> logger, IPersonService personService, IHistoryService historyService)
        {
            _logger = logger;
            _personService = personService;
            _historyService = historyService;
        }

        /*
         * Wyszukiwanie
         * Tutorial: https://www.youtube.com/watch?v=gb6TMtoGQEM
         */

        public void OnGet()
        {
            if (string.IsNullOrEmpty(user))
                records = _personService.GetPeopleToList();
            else
            {
                records = _personService.GetPersonsByNameToList(user);

                foreach (var item in records.People)
                {
                    _historyService.AddNewHistory(user, item.Id);
                }
            }               
        }
    }
}
