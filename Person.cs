public struct Person
{
    private int Id;
    public string Name { get; set; }
    private string FirstName;
    private string LastName;

    public Person(int id, string name, string firstName, string lastName)
    {
        Id = id;
        Name = name;
        FirstName = firstName;
        LastName = lastName;
    }
}