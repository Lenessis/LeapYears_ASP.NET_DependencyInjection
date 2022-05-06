using LeapYears.DTO;


namespace LeapYears.Interfaces
{
    public interface IPersonService
    {
        ListPersonDTO GetPeopleToList();
        PersonDTO GetPerson(int id);
        //void AddPerson(); // - z parametrem
    }
}
