using LeapYears.DTO;


namespace LeapYears.Interfaces
{
    public interface IPersonService
    {
        ListPersonDTO GetPeopleToList();
        PersonDTO GetOnePerson(int id);
        ListPersonDTO GetPersonsByNameToList(string phrase);
        void AddNewPerson(YearUser user);
    }
}
