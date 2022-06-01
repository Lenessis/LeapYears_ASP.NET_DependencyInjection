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

        public void AddNewPersonDB(YearUser user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public IQueryable<YearUser> GetAllPeople()
        {
            return _context.User;
        }

        public IQueryable<YearUser> GetPersonById(int id)
        {
            return _context.User.Where(p => p.Id.Equals(id));
        }

        public IQueryable<YearUser> GetPersonByName(string phrase)
        {
            var data = from u in _context.User
                       where u.name.Contains(phrase) || u.lastname.Contains(phrase)
                       orderby u.name, u.lastname
                       select new YearUser
                       {
                           Id = u.Id,
                           name = u.name,
                           lastname = u.lastname,
                           year = u.year                          
                       };

            return data;
        }
    }
}
