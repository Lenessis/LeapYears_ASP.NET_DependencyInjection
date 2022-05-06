using LeapYears.Data;
using LeapYears.Interfaces;
using System.Linq;

namespace LeapYears.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ContextDB _context;

        public PersonRepository (ContextDB context)
        {
            _context = context;
        }

        public IQueryable<YearUser> GetAllPeople()
        {
            return _context.User;
        }

        public IQueryable<YearUser> GetPersonById(int id)
        {
            return _context.User.Where(p => p.Id.Equals(id));
        }
    }
}
