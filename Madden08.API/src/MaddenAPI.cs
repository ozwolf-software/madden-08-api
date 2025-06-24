using Madden08.API.Domain;
using Madden08.API.Domain.Coach;
using Madden08.API.Domain.Common;

namespace Madden08.API;

using TDB;
using TDB.Table;
using Util;

/// <summary>
/// The <c>MaddenAPI</c> class is the master object for reading and writing data from a Madden roster or franchise file.
///
/// You should treat instances of this class as singletons.
/// </summary>
/// <example>
/// <c>
/// using(MaddenAPI api = MaddenAPI.Open("path/to/file.fra")) {
///    // do stuff
/// }
/// </c>
/// </example>
public class MaddenAPI : IDisposable
{
    private readonly string _fileName;
    private int _handle;
    private List<City>? _cities;
    private List<Team>? _teams;
    private List<DraftPick>? _draftPicks;
    private List<Stadium>? _stadiums;
    private List<Player>? _players;
    private List<Coach>? _coaches;

    private MaddenAPI(string fileName, int handle)
    {
        this._fileName = fileName;
        this._handle = handle;
    }

    /// <summary>The file name this API instance is configured with.</summary>
    public string FileName => _fileName;

    /// <summary>Flag indicating the file exists.</summary>
    public bool Exists => File.Exists(_fileName);

    /// <summary>The cities in the file.</summary>
    public List<City> Cities => this._cities ??= LoadTable(Tables.Cities);

    /// <summary>
    /// Update a city in the franchise file and receive the updated list of cities back.
    /// </summary>
    /// <param name="city">The city to update.</param>
    /// <returns>The updated list of cities.</returns>
    public List<City> Update(City city) => this._cities = SaveTable(Tables.Cities, city, _cities);

    /// <summary>
    /// Update the provided cities in the franchise file and receive the updated list of cities back.
    /// </summary>
    /// <param name="cities">The cities to update.</param>
    /// <returns>The updated list of cities.</returns>
    public List<City> Update(List<City> cities) => this._cities = SaveTable(Tables.Cities, cities, _cities);

    /// <summary>The teams in the file.</summary>
    public List<Team> Teams => this._teams ??= LoadTable(Tables.Teams);

    /// <summary>
    /// Update a team in the franchise file and receive the updated list of teams back.
    /// </summary>
    /// <param name="team">The team to update.</param>
    /// <returns>The updated list of teams.</returns>
    public List<Team> Update(Team team) => this._teams = SaveTable(Tables.Teams, team, _teams);

    /// <summary>
    /// Update the provided teams in the franchise file and receive the updated list of teams back.
    /// </summary>
    /// <param name="teams">The teams to update.</param>
    /// <returns>The updated list of teams.</returns>
    public List<Team> Update(List<Team> teams) => this._teams = SaveTable(Tables.Teams, teams, _teams);

    /// <summary>The coaches in the file.</summary>
    public List<Coach> Coaches => this._coaches ??= LoadTable(Tables.Coaches);

    /// <summary>
    /// Update a coach in the franchise file and receive the updated list of coaches back.
    /// </summary>
    /// <param name="coach">The coach to update.</param>
    /// <returns>The updated list of coaches.</returns>
    public List<Coach> Update(Coach coach) => this._coaches = SaveTable(Tables.Coaches, coach, _coaches);

    /// <summary>
    /// Update the provided coaches in the franchise file and receive the updated list of coaches back.
    /// </summary>
    /// <param name="coaches">The coaches to update.</param>
    /// <returns>The updated list of coaches.</returns>
    public List<Coach> Update(List<Coach> coaches) => this._coaches = SaveTable(Tables.Coaches, coaches, _coaches);

    /// <summary>The draft picks in the file.</summary>
    public List<DraftPick> DraftPicks => this._draftPicks ??= LoadTable(Tables.DraftPicks);

    /// <summary>
    /// Update a draft pick in the franchise file and receive the updated list of draft picks back.
    /// </summary>
    /// <param name="pick">The draft pick to update.</param>
    /// <returns>The updated list of draft picks.</returns>
    public List<DraftPick> Update(DraftPick pick) => this._draftPicks = SaveTable(Tables.DraftPicks, pick, _draftPicks);

    /// <summary>
    /// Update the provided draft picks in the franchise file and receive the updated list of draft picks back.
    /// </summary>
    /// <param name="picks">The draft picks to update.</param>
    /// <returns>The updated list of draft picks.</returns>
    public List<DraftPick> Update(List<DraftPick> picks) => this._draftPicks = SaveTable(Tables.DraftPicks, picks, _draftPicks);

    /// <summary>The stadiums in the file.</summary>
    public List<Stadium> Stadiums => this._stadiums ??= LoadTable(Tables.Stadiums);

    /// <summary>
    /// Update a stadium in the franchise file and receive the updated list of stadiums back.
    /// </summary>
    /// <param name="stadium">The stadium to update.</param>
    /// <returns>The updated list of stadiums.</returns>
    public List<Stadium> Update(Stadium stadium) => this._stadiums = SaveTable(Tables.Stadiums, stadium, _stadiums);

    /// <summary>
    /// Update the provided stadiums in the franchise file and receive the updated list of stadiums back.
    /// </summary>
    /// <param name="stadiums">The stadiums to update.</param>
    /// <returns>The updated list of stadiums.</returns>
    public List<Stadium> Update(List<Stadium> stadiums) => this._stadiums = SaveTable(Tables.Stadiums, stadiums, _stadiums);

    /// <summary>The players in the file.</summary>
    public List<Player> Players => this._players ??= LoadTable(Tables.Players);

    /// <summary>
    /// Update a player in the franchise file and receive the updated list of players back.
    /// </summary>
    /// <param name="player">The player to update.</param>
    /// <returns>The updated list of players.</returns>
    public List<Player> Update(Player player) => this._players = SaveTable(Tables.Players, player, _players);

    /// <summary>
    /// Update the provided players in the franchise file and receive the updated list of players back.
    /// </summary>
    /// <param name="players">The players to update.</param>
    /// <returns>The updated list of players.</returns>
    public List<Player> Update(List<Player> players) => this._players = SaveTable(Tables.Players, players, _players);

    /// <summary>
    /// Close the Madden file.  This needs to be done to ensure any locks are released.
    /// </summary>
    /// <exception cref="InvalidOperationException">If there was an error closing the file.</exception>
    public void Close()
    {
        if (_handle > -1 && !TDBAccess.TDBClose(_handle))
            throw new InvalidOperationException($"Failed to close file [ {_fileName} ]");
        _handle = -1;
    }

    /// <summary>
    /// Same functionality as <c>Close()</c>, except it allows the <c>MaddenAPI</c> class to be wrapped in a <c>using</c> block.
    /// </summary>
    public void Dispose()
    {
        this.Close();
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Compact and save the Madden file.  Until this operation has been called, changes are not persisted.
    /// </summary>
    /// <exception cref="InvalidOperationException">If there is an error saving the file.</exception>
    public void CompactAndSave()
    {
        if (_handle < 0)
            throw new InvalidOperationException("File has not been opened.");
        if (!TDBAccess.TDBDatabaseCompact(_handle))
            throw new InvalidOperationException("Failed to compact database.");
        if (!TDBAccess.TDBSave(_handle))
            throw new InvalidOperationException("Failed to save database.");
    }

    /// <summary>
    /// Reload the file without saving any changed state.
    /// </summary>
    /// <returns>A new <c>MaddenAPI</c> instance reloaded from the file.</returns>
    public MaddenAPI Reload()
    {
        this.Close();
        return MaddenAPI.Open(_fileName);
    }

    private List<T> LoadTable<T>(ITable<T> table)
    {
        if (_handle < 0)
            throw new InvalidOperationException("File has not been opened.");
        var properties = GetTable(table.Name);
        return Enumerable.Range(0, properties.RecordCount)
            .Select(record => table.Load(new TableRecord(_handle, properties, record)))
            .ToList();
    }

    private List<T> SaveTable<T>(ITable<T> table, T item, IReadOnlyCollection<T>? current) where T: IDomainRecord => SaveTable(table, [item], current);

    private List<T> SaveTable<T>(ITable<T> table, IEnumerable<T> items, IReadOnlyCollection<T>? current) where T : IDomainRecord
    {
        if (_handle < 0)
            throw new InvalidOperationException("File has not been opened for reading and writing.");
        if (current == null)
            throw new InvalidDataException("The data has not been loaded for modification.");

        var properties = GetTable(table.Name);
        var modifiedRecords = items.Select(i =>
        {
            TableRecord record = new(_handle, properties, i.Record);
            table.Save(i, record);
            return new KeyValuePair<int, T>(i.Record, i);
        }).ToDictionary();

        return current.Select(c => modifiedRecords.GetValueOrDefault(c.Record, c)).ToList();
    }

    private TableProperties GetTable(string tableName)
    {
        for (var i = 0; i < TDBAccess.TDBDatabaseGetTableCount(_handle); i++)
        {
            TableProperties properties = new();
            if(!TDBAccess.TDBTableGetProperties(_handle, i, ref properties)) continue;
            if (properties.Name.EqualsIgnoreCase(tableName)) return properties;
        }

        throw new InvalidOperationException($"Unknown table [ {tableName} ]");
    }

    /// <summary>
    /// Open the Madden file.
    /// </summary>
    /// <returns>A new MaddenAPI instance opened for the franchise file.</returns>
    /// <exception cref="InvalidOperationException">If there was an error opening the file.</exception>
    public static MaddenAPI Open(string fileName)
    {
        if (!File.Exists(fileName))
            throw new InvalidOperationException($"File [ {fileName} ] could not be found.");

        var handle = TDBAccess.TDBOpen(fileName);
        if (handle < 0)
            throw new InvalidOperationException($"Failed to open [ {fileName} ]");
        return new MaddenAPI(fileName, handle);
    }
}