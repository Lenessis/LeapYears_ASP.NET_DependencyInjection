using LeapYears.DTO;

namespace LeapYears.Interfaces
{
    public interface IHistoryService
    {
        ListHistoryDTO GetHistoryToList();
        ListHistoryDTO GetHistoryToList(bool today);
    }
}
