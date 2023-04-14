using EntityLearn;
using EntityLearn.Repository;

var temp = new PersonDbContext();

temp.adress.Add(new Adress
{
    Country = "Uzb",
    Region = "Navoi",
    City = "Nurota",
    PostalCode = "210700"
});

temp.SaveChanges();

Adress adress = temp.adress.Where(x => x.Country == "Uzb").Select(x => x).FirstOrDefault();

temp.persons.Add(new Person()
{
    FirstName = "Zuhriddin",
    LastName = "Zayniddinov",
    AdressId = adress.Id
});
temp.SaveChanges();
Console.WriteLine(temp.persons.FirstOrDefault());