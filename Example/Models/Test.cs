namespace Example.Models;

/// <summary>
/// A test
/// </summary>
public record Test
{
	/// <summary>
	/// The tested user
	/// </summary>
	public Person User { get; set; }

	/// <summary>
	/// The grade
	/// </summary>
	public int Grade { get; set; }
}