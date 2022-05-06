using LeapYears.DTO;
using LeapYears.Interfaces;
using System.Collections.Generic;

namespace LeapYears.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository; 
        //private readonly IPersonService _personService;

        public HistoryService (IHistoryRepository historyRepository/*, IPersonService personService*/)
        {
            _historyRepository = historyRepository;
           // _personService = personService;
        }

        public ListHistoryDTO GetHistoryToList()
        {
            return GetHistoryToList(false);
        }

        public ListHistoryDTO GetHistoryToList(bool today)
        {
            var history = (today) ? _historyRepository.GetTodayHistory() : _historyRepository.GetAllHistory();

            ListHistoryDTO result = new ListHistoryDTO();
            result.History = new List<HistoryDTO>();

            foreach (var item in history)
            {
                //PersonDTO personName = _personService.GetPerson(item.YearUserId);
                var newHistoryItem = new HistoryDTO()
                {
                    Id = item.Id,
                    Date = item.date,
                    Result = item.result,
                    //Fullname = item.YearUser.name + " " + item.YearUser.lastname
                    Fullname = item.YearUserId.ToString()
                    
                };
                result.History.Add(newHistoryItem);
            }

            result.Count = result.History.Count;

            return result;
        }
      
    }
}
