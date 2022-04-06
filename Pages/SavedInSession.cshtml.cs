using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace LeapYears.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public List<YearUser> yearsList = new List<YearUser>();

        public void OnGet()
        {
            var YearData = HttpContext.Session.GetString("YearList");
            if (YearData != null)
                yearsList = JsonConvert.DeserializeObject<List<YearUser>>(YearData);
        }   
    }
}
