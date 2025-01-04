namespace Packt.Shared;

public class Person : object
{
    public string? Name;
    public DateTimeOffset Born;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public List<Person> Children = new();

    // Constant fields: Values that are fixed at compilation.
    public const string Species = "Homo Sapiens";

    // Read-only fields: Values that can be set at runtime.
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
}
