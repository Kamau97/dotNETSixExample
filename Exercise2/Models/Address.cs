namespace Exercise2.Models;
/// <summary>
/// An address
/// </summary>
public class Address
{
    /// <summary>
    /// The street
    /// </summary>
    public string Street { get; set; } = null!;

    /// <summary>
    /// The zip
    /// </summary>
    public string? Zip { get; set; } = null!;

    /// <summary>
    /// The city
    /// </summary>
    public string City { get; set; } = null!;

    /// <summary>
    /// The country
    /// </summary>
    public string Country { get; set; } = null!;

    /// <summary>
    /// The district
    /// </summary>
    public string? District { get; set; }

    public override string ToString() => $"{Street}\n{Zip} {City}\n{Country}\n{District}";
}