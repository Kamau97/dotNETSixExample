namespace Exercise2.Models;
/// <summary>
/// A stage
/// </summary>
public class Stage
{
    /// <summary>
    /// The unique identifier
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The width in meters
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// The height in meters
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// The depth in meters
    /// </summary>
    public double Depth { get; set; }
    
    /// <summary>
    /// The background
    /// </summary>
    public Background Background { get; set; } = null!;
}