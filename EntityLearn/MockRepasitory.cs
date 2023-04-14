namespace EntityLearn;

internal class MockRepasitory
{
    private List<Person> persons;

    public MockRepasitory()
    {
        persons = new List<Person>()
        {
            new Person {
                Id = 1,
                FirstName = "Fozil",
                LastName = "Jamolov"
            },
            new Person {
                Id = 2,
                FirstName = "Diyor",
                LastName = "Olimov",
                Phone = "+998996632145"
            },
        };
    }
    public Person Get(int id)
    {
        return persons.Find(per => per.Id == id);
    }
    public Person Create(Person person)
    {
        int id = persons.Max(person => person.Id);
        person.Id = id + 1;
        persons.Add(person);
        return person;
    }
    public Person Delete(int id)
    {
        var person = persons.Find(per => per.Id == id);
        persons.Remove(person);
        return person;
    }
}
