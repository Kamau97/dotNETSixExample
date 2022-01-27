namespace Example.Models;

public record Person(
    string FirstName,
    string LastName,
    DateTimeOffset DateOfBirth,
    int Gender,
    Address Address);

public record Address
{
    /// <summary>
    /// The zip-code
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// The city
    /// </summary>
    public string City { get; set; } = null!;

    /// <summary>
    /// The street with the number
    /// </summary>
    public string Street { get; set; } = null!;
}

public record struct Gender
{
    public static int Unknown => 0;
    public static int Male => 1;
    public static int Female => 2;
    public static int NotApplicable => 9;
}