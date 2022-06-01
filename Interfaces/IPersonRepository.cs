using System.Linq;

namespace LeapYears.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<YearUser> GetAllPeople();
        IQueryable<YearUser> GetPersonById(int id);
        IQueryable<YearUser> GetPersonByName(string phrase);
        void AddNewPersonDB(YearUser user);
    }
}
