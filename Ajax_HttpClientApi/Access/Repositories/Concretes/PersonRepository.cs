namespace Ajax_HttpClientApi.Access.Repositories.Concretes
{
    public class PersonRepository : IPersonRepository
    {
        #region Seed Data
        List<Person> persons = new List<Person>()
        {
            new Person() { Id=1, FullName="Ahmet Yılmaz", BirthOfDate=new DateTime(2002,01,05) },
            new Person() { Id=2, FullName="Mine Yılmaz", BirthOfDate=new DateTime(2002,01,05) },
            new Person() { Id=3, FullName="Kemal Yılmaz", BirthOfDate=new DateTime(2002,01,05) }
        };
        #endregion

        public bool Create(Person person)
        {
            persons.Add(person);
            return true;
        }

        public bool Delete(int id)
        {
            Person person = Get(id);
            return persons.Remove(person);
        }

        public Person Get(int id)
        {
            return persons.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return persons;
        }

        public bool Update(Person person)
        {
            Person deletePerson = Get(person.Id);
            persons.Remove(deletePerson);
            persons.Add(person);
            return true;
        }
    }
}
