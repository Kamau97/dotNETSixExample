namespace Exercise2.Models;
/// <summary>
/// A location
/// </summary>
public class Location
{
    /// <summary>
    /// The unique identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The name
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// The address
    /// </summary>
    public Address Address { get; set; } = null!;

    public Stage Stage { get; set; } = null!;
}