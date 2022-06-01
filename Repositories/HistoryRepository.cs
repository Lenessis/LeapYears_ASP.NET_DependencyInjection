using LeapYears.Data;
using LeapYears.Interfaces;
using LeapYears.Models;
using System.Linq;
using System;

namespace LeapYears.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly ContextDB _context;

        public HistoryRepository (ContextDB context)
        {
            _context = context;
        }

        public void AddNewHistoryToDB(HistoryUser history)
        {
            _context.History.Add(history);
            _context.SaveChanges();
        }

        public IQueryable<HistoryUser> GetAllHistory()
        {
            return _context.History.OrderByDescending(p => p.date);
        }

        public IQueryable<HistoryUser> GetLimitedHistory()
        {
            var data = from h in _context.History
                       join u in _context.User
                       on h.YearUserId equals u.Id
                       orderby h.date descending
                       select new HistoryUser
                       {
                           Id = h.Id,
                           date = h.date,
                           result = h.result,
                           YearUserId = u.Id,
                           YearUser = new YearUser
                           {
                               Id = u.Id,
                               name = u.name,
                               lastname = u.lastname,
                               year = u.year
                           }
                       };
            data.Take(20);

            return data;
        }

        public IQueryable<HistoryUser> GetTodayHistory()
        {

            DateTime today = DateTime.Now;
            var data = from h in _context.History
                       join u in _context.User
                       on h.YearUserId equals u.Id
                       where h.date.Year.Equals(today.Year) &&
                             h.date.Month.Equals(today.Month) &&
                             h.date.Day.Equals(today.Day)
                       orderby h.date descending
                       select new HistoryUser
                       {
                           Id = h.Id,
                           date = h.date,
                           result = h.result,
                           YearUserId = u.Id,
                           YearUser = new YearUser
                           {
                               Id = u.Id,
                               name = u.name,
                               lastname = u.lastname,
                               year = u.year
                           }
                       };

            return  data;
        } 
    }
}
