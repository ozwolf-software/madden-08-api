using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>StadiumSection</c> class contains the various stadium section enums used to configure a stadium.
/// </summary>
public static class StadiumSection
{
    /// <summary>
    /// The <c>Corner</c> enum represents the various configurations a stadium corner can have.
    /// </summary>
    public enum Corner
    {
        /// <summary>Extended</summary>
        [DisplayName("Extended"), CapacityAdjustment]
        Extended = 0,

        /// <summary>Tunnel</summary>
        [DisplayName("Tunnel"), CapacityAdjustment(LowerLevel = -400, ClubSeats = 50)]
        Tunnel = 1,

        /// <summary>Straight</summary>
        [DisplayName("Straight"), CapacityAdjustment(LowerLevel = -185)]
        Straight = 2,

        /// <summary>Stairs</summary>
        [DisplayName("Stairs"), CapacityAdjustment(LowerLevel = -185)]
        Stairs = 3
    }

    /// <summary>
    /// The <c>EndzoneTier1</c> enum represents the type of configuration for the first level of of the endzone in a created stadium.
    ///
    /// It exposes the <c>DisplayName()</c> attribute.
    /// </summary>
    public enum EndzoneTier1
    {
        /// <summary>Indent</summary>
        [DisplayName("Indent"), CapacityAdjustment]
        Indent = 0,

        /// <summary>Sairs</summary>
        [DisplayName("Stairs"), CapacityAdjustment(LowerLevel = 575, ClubSeats = -50)]
        Stairs = 1,

        /// <summary>Tunnel</summary>
        [DisplayName("Tunnel"), CapacityAdjustment(LowerLevel = 175)]
        Tunnel = 2,

        /// <summary>Straight</summary>
        [DisplayName("Straight"), CapacityAdjustment(LowerLevel = 575, ClubSeats = -50)]
        Straight = 3
    }

    /// <summary>
    /// The <c>EndzoneTier2</c> enum represents the various configurations the tier 2 deck of a stadium endzone can be configured with.
    ///
    /// It exposes the <c>DisplayName()</c> attribute.
    /// </summary>
    public enum EndzoneTier2
    {
        /// <summary>Straight</summary>
        [DisplayName("Straight"), CapacityAdjustment]
        Straight = 0,

        /// <summary>Scoreboard Cut In</summary>
        [DisplayName("Scoreboard Cut In"), CapacityAdjustment(MidLevel = -1175, ClubSeats = -50)]
        ScoreboardCutIn = 1,

        /// <summary>Scoreboard</summary>
        [DisplayName("Scoreboard"), CapacityAdjustment(MidLevel = -900, ClubSeats = -100)]
        Scoreboard = 2,

        /// <summary>Open Ended</summary>
        [DisplayName("Open Ended"), CapacityAdjustment]
        OpenEnded = 3
    }

    /// <summary>
    /// The <c>EndzoneTier3</c> enum represents the various configurations the top tier of a stadium endzone can be.
    ///
    /// It exposes the <c>DisplayName()</c> attribute.
    /// </summary>
    public enum EndzoneTier3
    {
        /// <summary>Straight</summary>
        [DisplayName("Straight"), CapacityAdjustment]
        Straight = 0,

        /// <summary>Scoreboard</summary>
        [DisplayName("Scoreboard")] Scoreboard = 1,

        /// <summary>Split Scoreboard</summary>
        [DisplayName("Split Scoreboard")] SplitScoreboard = 2,

        /// <summary>Open Scoreboard</summary>
        [DisplayName("Open Scoreboard"), CapacityAdjustment(UpperEndZone = -4400, MidLevel = -3400, UpperLevel = -600, ClubSeats = -150)]
        OpenScoreboard = 3,

        /// <summary>Closed Scoreboard</summary>
        [DisplayName("Closed Scoreboard"), CapacityAdjustment(UpperEndZone = -200, MidLevel = -3400, UpperLevel = -600, ClubSeats = -150)]
        ClosedScoreboard = 4
    }

    /// <summary>
    /// The <c>SidelineTier1</c> enum represents the various configurations the lower tier of a stadium sideline can be.
    ///
    /// It exposes the <c>DisplayName()</c> attribute.
    /// </summary>
    public enum SidelineTier1
    {
        /// <summary>Straight</summary>
        [DisplayName("Straight")] Straight = 0,

        /// <summary>Stairs</summary>
        [DisplayName("Stairs")] Stairs = 1,

        /// <summary>Tunnel</summary>
        [DisplayName("Tunnel")] Tunnel = 2,

        /// <summary>Indented</summary>
        [DisplayName("Indented")] Indented = 3
    }

    /// <summary>
    /// The <c>SidelineTier2</c> enum represents the various configurations the middle tier of a stadium sideline can be.
    ///
    /// It exposes the <c>DisplayName()</c> attribute.
    /// </summary>
    public enum SidelineTier2
    {
        /// <summary>Straight</summary>
        [DisplayName("Straight")] Straight = 0,

        /// <summary>Press Luxury Boxes</summary>
        [DisplayName("Press Luxury Boxes")] PressLuxury = 1,

        /// <summary>Open</summary>
        [DisplayName("Open")] Open = 2,

        /// <summary>Upper Decks</summary>
        [DisplayName("Upper Decks")] Decks = 3
    }

    /// <summary>
    /// The <c>SidelineTier3</c> enum represents the various configurations the upper tier of a stadium sideline can be.
    ///
    /// It exposes the <c>DisplayName()</c> attribute.
    /// </summary>
    public enum SidelineTier3
    {
        /// <summary>Straight</summary>
        [DisplayName("Straight")] Straight = 0,

        /// <summary>Press Luxury Boxes</summary>
        [DisplayName("Press Luxury Boxes")] PressLuxury = 1,

        /// <summary>Press Boxes</summary>
        [DisplayName("Press Boxes")] Press = 3
    }

    /// <summary>
    /// The <c>LightType</c> enum represents the various configurations for stadium lights.
    ///
    /// <strong>Note:</strong> This setting is mutually exclusive to roof type.
    /// </summary>
    public enum LightType
    {
        /// <summary>None</summary>
        [DisplayName("None")] None = 0,

        /// <summary>Four Lights</summary>
        [DisplayName("Four Lights")] FourLights = 1,

        /// <summary>Six Lights</summary>
        [DisplayName("Six Lights")] SixLights = 2,

        /// <summary>Eight Lights</summary>
        [DisplayName("Eight Lights")] EightLights = 3,
    }

    /// <summary>
    /// The <c>RoofTypes</c> enum represents the various configurations for stadium roofs.
    ///
    /// <strong>Note:</strong> This setting is mutually exclusive to light type.  If either endzone is configured as open ended, roof types will be ignored.
    /// </summary>
    public enum RoofType
    {
        /// <summary>None</summary>
        [DisplayName("None")] None = 0,

        /// <summary>Dome</summary>
        [DisplayName("Dome")] Dome = 1,

        /// <summary>Open Cut</summary>
        [DisplayName("Open Cut")] OpenCut = 2,

        /// <summary>Modern Dome</summary>
        [DisplayName("Modern Dome")] ModernDome = 3,

        /// <summary>Raised Roof</summary>
        [DisplayName("Raised Roof")] Raised = 4,

        /// <summary>Flat Dome</summary>
        [DisplayName("Flat Dome")] FlatDome = 5
    }
}