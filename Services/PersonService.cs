using LeapYears.DTO;
using LeapYears.Interfaces;
using System.Collections.Generic;

namespace LeapYears.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService (IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public ListPersonDTO GetPeopleToList()
        {
            var people = _personRepository.GetAllPeople();

            ListPersonDTO result = new ListPersonDTO();
            result.People = new List<PersonDTO>();

            foreach (var person in people)
            {
                var newPersonItem = new PersonDTO()
                {
                    Id = person.Id,
                    Fullname = person.name + " " + person.lastname,
                    Year = person.year
                };
                result.People.Add(newPersonItem);
            }

            result.Count = result.People.Count;
            return result;
        }

        public PersonDTO GetPerson(int id)
        {
            var person = _personRepository.GetPersonById(id);

            if (person == null)
                return null;

            else
            {
                PersonDTO result = new PersonDTO();

                foreach (var item in person)
                {
                    result.Fullname = item.name + " " + item.lastname;
                    result.Year = item.year;
                }
                return result;
            }               
        }
    }
}
