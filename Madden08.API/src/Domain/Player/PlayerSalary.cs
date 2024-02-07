namespace Madden08.API.Domain;

/// <summary>
/// The <c>PlayerSalary</c> class represents a single year salary for a player.
/// </summary>
/// <param name="Year">The salary year.</param>
/// <param name="Salary">The player salary.</param>
/// <param name="Bonus">The player bonus.</param>
public record PlayerSalary(int Year, int Salary, int Bonus)
{
    /// <summary>
    /// Create a ZERO salary instance for the given year.
    /// </summary>
    /// <param name="Year">The salary year.</param>
    public PlayerSalary(int Year) : this(Year, 0, 0)
    {}

    /// <summary>
    /// The total of the salary year.
    /// </summary>
    public int Total => Salary + Bonus;

    /// <summary>
    /// Removes the bonus from the salary year.  Generally done when a player is released or traded.
    /// </summary>
    /// <returns>A new player salary instance with a zero bonus.</returns>
    public PlayerSalary ClearBonus() => this with { Bonus = 0 };

    /// <summary>
    /// Removes both the salary and bonus and sets them to zero.
    /// </summary>
    /// <returns>A new player salary instance with zero salary and bonus.</returns>
    public PlayerSalary Zero() => this with { Salary = 0, Bonus = 0 };
}