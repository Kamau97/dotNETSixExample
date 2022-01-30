namespace Exercise2.Models;
/// <summary>
/// The background of a stage
/// </summary>
public class Background
{
    /// <summary>
    /// The unique identifier
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// The height in meters
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// The width in meters
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// If it is a screen or wall
    /// </summary>
    public bool IsScreen { get; set; }
}