using LeapYears.Models;
using System.Linq;

namespace LeapYears.Interfaces
{
    public interface IHistoryRepository
    {
        IQueryable<HistoryUser> GetAllHistory();
        IQueryable<HistoryUser> GetTodayHistory();
    }
}
