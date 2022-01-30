namespace Exercise2.Models;
/// <summary>
/// A generic event (like e.g. a concert)
/// </summary>
public class Event
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// The name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// The date
    /// </summary>
    public DateTimeOffset Date { get; set; }
    
    /// <summary>
    /// The location
    /// </summary>
    public Location Location { get; set; } = null!;

    /// <summary>
    /// List of associated acts
    /// </summary>
    public List<object> Acts { get; set; } = null!;
}