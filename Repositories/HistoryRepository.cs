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

        public IQueryable<HistoryUser> GetAllHistory()
        {
            return _context.History.OrderByDescending(p => p.date);
        }

        public IQueryable<HistoryUser> GetTodayHistory()
        {
            DateTime today = DateTime.Now;
            return _context.History
                .Where(p => 
                  p.date.Year.Equals(today.Year) && 
                  p.date.Month.Equals(today.Month) &&
                  p.date.Day.Equals(today.Day))
                .OrderByDescending(p => p.date);
        } //wstrzykiwanie serwisów + dodawanie do bazy + wyświetlanie + person?
    }
}
