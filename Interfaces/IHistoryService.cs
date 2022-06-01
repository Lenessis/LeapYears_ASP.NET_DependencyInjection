using LeapYears.DTO;

namespace LeapYears.Interfaces
{
    public interface IHistoryService
    {
        ListHistoryDTO GetHistoryToList();
        ListHistoryDTO GetLimitedHistoryToList();
        ListHistoryDTO GetHistoryToList(bool today);
        public void AddNewHistory(string result, int userId);
    }
}
