using System.Linq;

namespace LeapYears.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<YearUser> GetAllPeople();
    }
}
