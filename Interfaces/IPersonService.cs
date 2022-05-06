using LeapYears.DTO;


namespace LeapYears.Interfaces
{
    public interface IPersonService
    {
        ListPersonDTO GetPeopleToList();
        //void AddPerson(); // - z parametrem
    }
}
