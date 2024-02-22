namespace Packt.Shared;

public partial class Person : object
{
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();

    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    public void Deconstruct(out string? name, out DateTime dob)
    {
        name = Name;
        dob = DateOfBirth;
    }

    public void Deconstruct(out string? name, out DateTime dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = DateOfBirth;
        fav = FavoriteAncientWonder;
    }

    public void PassingParameters(int x, ref int y, out int z)
    {
        z = 99;
        x++;
        y++;
        z++;
    }
}