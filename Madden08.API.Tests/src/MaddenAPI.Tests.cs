using Madden08.API.Domain;

namespace Madden08.API.Tests;

[TestClass]
public class MaddenAPITests
{
    [TestCleanup]
    public void Cleanup()
    {
        File.Delete("test_files//SFL_Write.fra");
    }

    [TestMethod]
    public void GetCitiesTest()
    {
        using var api = API();
        var cities = api.Cities;
        Assert.AreEqual(102, cities.Count);

        var sanAntonio = cities.Find(c => string.Equals(c.Name, "San Antonio", StringComparison.OrdinalIgnoreCase));
        Assert.IsNotNull(sanAntonio);
        Assert.AreEqual(1405143, sanAntonio.Population);
        Assert.AreEqual(CityRegion.SouthWest, sanAntonio.Region);
    }

    [TestMethod]
    public void GetTeamsTest()
    {
        using var api = API();
        var teams = api.Teams;
        Assert.AreEqual(35, teams.Count);

        var steelers = teams.Find(t => t.Name == "Pittsburgh");
        Assert.IsNotNull(steelers);
        Assert.AreEqual("Steelers", steelers.NickName);
        Assert.AreEqual("PIT", steelers.ShortName);
        Assert.AreEqual("Steelers", steelers.OtherName);
    }

    [TestMethod]
    public void GetDraftPicksTest()
    {
        using var api = API();
        var picks = api.DraftPicks;
        Assert.AreEqual(224, picks.Count);
    }

    [TestMethod]
    public void ModifyFileTest()
    {
        using var api = API();
        File.Copy(api.FileName, "test_files/SFL_Write.fra", true);

        using var writeFile = MaddenAPI.Open("test_files/SFL_Write.fra");

        var team = writeFile.Teams.Find(t => t.Name == "Pittsburgh");
        Assert.IsNotNull(team);
        Assert.AreEqual("Steelers", team.OtherName);

        var modified = team.WithName(otherName: "Yellowjackets");
        Assert.AreEqual("Yellowjackets", modified.OtherName);
        writeFile.Update(modified);

        var updated = writeFile.Teams.Find(t => t.Name == "Pittsburgh");
        Assert.IsNotNull(updated);
        Assert.AreEqual("Yellowjackets", updated.OtherName);

        writeFile.CompactAndSave();

        using var reloaded = writeFile.Reload();
        var reloadedTeams = reloaded.Teams;
        Assert.AreEqual(35, reloadedTeams.Count);
        var reloadedTeam = reloadedTeams.Find(t => t.Name == "Pittsburgh");
        Assert.IsNotNull(reloadedTeam);
        Assert.AreEqual("Yellowjackets", reloadedTeam.OtherName);
    }

    private static MaddenAPI API() => MaddenAPI.Open("test_files//SFL.fra");
}