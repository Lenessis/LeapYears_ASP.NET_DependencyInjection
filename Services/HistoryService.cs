﻿using LeapYears.DTO;
using LeapYears.Interfaces;
using System.Collections.Generic;

namespace LeapYears.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository; 

        public HistoryService (IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
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
                var newHistoryItem = new HistoryDTO()
                {
                    Id = item.Id,
                    Date = item.date,
                    Result = item.result,
                    Fullname = item.YearUser.name + " " + item.YearUser.lastname
                };
                result.History.Add(newHistoryItem);
            }

            result.Count = result.History.Count;

            return result;
        }
      
    }
}
