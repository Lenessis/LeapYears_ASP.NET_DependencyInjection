using LeapYears.Models;
using System.Linq;

namespace LeapYears.Interfaces
{
    public interface IHistoryRepository
    {
        IQueryable<HistoryUser> GetAllHistory();
        IQueryable<HistoryUser> GetLimitedHistory();
        IQueryable<HistoryUser> GetTodayHistory();
        void AddNewHistoryToDB(HistoryUser history);
    }
}
