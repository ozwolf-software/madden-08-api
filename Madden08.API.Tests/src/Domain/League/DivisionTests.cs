using Madden08.API.Domain;
using Madden08.API.Util;

namespace Madden08.API.Tests.Domain.League;

[TestClass]
public class DivisionTests
{
    [TestMethod]
    public void ShouldReturnDivisionConference()
    {
        const Division division = Division.AFCEast;
        Assert.AreEqual(Conference.AFC, division.Conference());
        Assert.AreEqual("AFC East", division.DisplayName());
    }
}