using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeapYears.Models
{
    public class History
    {
        public int      Id      { get; set; }
        public DateTime date    { get; set; }
        public int      result  { get; set; } // liczba pozostałych wyników

        public int YearUserId { get; set; }
        public virtual YearUser YearUser { get; set; }

        public History()
        {
            date = DateTime.Now;
            result = 1;
        }

        public History(int result, int userId)
        {
            date = DateTime.Now;
            this.result = result;
            YearUserId = userId;
        }

        public History(int result, int userId, YearUser user)
        {
            date = DateTime.Now;
            this.result = result;
            YearUserId = userId;
            YearUser = user;
        }
    }
}
