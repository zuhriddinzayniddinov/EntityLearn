namespace EntityLearn;
internal class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Title { get; set; }
    public int AdressId { get; set; }
    public Adress? Address { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? HomePhone { get; set; }
    public string? Extension { get; set; }
    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}
