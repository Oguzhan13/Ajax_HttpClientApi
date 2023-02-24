namespace Ajax_HttpClientApi.Access.Repositories.Abstracts
{
    public interface IPersonRepository
    {
        bool Create(Person person);
        bool Delete(int id);
        bool Update(Person person);
        Person Get(int id);
        IEnumerable<Person> GetAll();
    }
}
