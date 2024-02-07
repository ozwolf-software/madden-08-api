namespace Madden08.API.Domain;

/// <summary>
/// The <c>PlayerContract</c> class represents a players current contract they have.
/// </summary>
/// <param name="Length">The total length of the contract.</param>
/// <param name="YearsLeft">The years left on the contract.</param>
/// <param name="Salaries">The yearly salary breakdown of the contract</param>
public record PlayerContract(int Length, int YearsLeft, List<PlayerSalary> Salaries)
{
    /// <summary>
    /// A representation of a zero contract.  Usually reserved for free agents.
    /// </summary>
    public static readonly PlayerContract Zero = new(0, 0, Enumerable.Range(1, 7).Select(y => new PlayerSalary(y)).ToList());

    /// <summary>
    /// Return which year (1 to 7) of the contract is the current year.
    /// </summary>
    public int CurrentContractYear => Length - YearsLeft + 1;

    /// <summary>
    /// Return the current salary for the contract.
    /// </summary>
    /// <exception cref="InvalidDataException">If a salary for the current year could not be found.</exception>
    public PlayerSalary CurrentSalary => Salaries.Find(s => s.Year == CurrentContractYear) ?? throw new InvalidDataException("Could not find salary for the current salary year.");

    /// <summary>
    /// Calculates the remaining bonus on a players contract.
    /// </summary>
    public int RemainingBonus => Salaries.FindAll(s => s.Year >= CurrentContractYear).Sum(s => s.Bonus);

    /// <summary>
    /// Clears all remaining bonuses on a players contract.
    /// </summary>
    /// <returns>A new contract instance with the bonuses cleared.</returns>
    public PlayerContract ClearBonus() => this with { Salaries = Salaries.Select(s => s.ClearBonus()).ToList() };

    /// <summary>
    /// Retrieve the player salary for a given contract year.
    /// </summary>
    /// <param name="year">The contract year.</param>
    /// <returns>The player salary.</returns>
    /// <exception cref="InvalidOperationException">If no salary found for that year.</exception>
    public PlayerSalary GetSalary(int year) => this.Salaries.Find(s => s.Year == year) ?? throw new InvalidOperationException($"Could not find salary for year [ {year} ]");
}