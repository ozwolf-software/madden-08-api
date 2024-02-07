using Madden08.API.Domain.Common;
using Madden08.API.Util;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>PlayerPosition</c> enum represents the various roster and depth chart positions players can fill.
///
/// This exposes the <c>Value()</c>, IsDepthChartOnly(), and <c>SubGroup()</c> attributes.
/// </summary>
public enum PlayerPosition
{
    /// <summary>Quarterback</summary>
    [DisplayName("Quarterback"), PositionSubGroup(PlayerPositionSubGroup.QB)]
    QB = 0,

    /// <summary>Half Back</summary>
    [DisplayName("Half Back"), PositionSubGroup(PlayerPositionSubGroup.HB)]
    HB = 1,

    /// <summary>Full Back</summary>
    [DisplayName("Full Back"), PositionSubGroup(PlayerPositionSubGroup.FB)]
    FB = 2,

    /// <summary>Wide Receiver</summary>
    [DisplayName("Wide Receiver"), PositionSubGroup(PlayerPositionSubGroup.WR)]
    WR = 3,

    /// <summary>Tight End</summary>
    [DisplayName("Tight End"), PositionSubGroup(PlayerPositionSubGroup.TE)]
    TE = 4,

    /// <summary>Left Tackle</summary>
    [DisplayName("Left Tackle"), PositionSubGroup(PlayerPositionSubGroup.OT)]
    LT = 5,

    /// <summary>Left Guard</summary>
    [DisplayName("Left Guard"), PositionSubGroup(PlayerPositionSubGroup.OG)]
    LG = 6,

    /// <summary>Center</summary>
    [DisplayName("Center"), PositionSubGroup(PlayerPositionSubGroup.C)]
    C = 7,

    /// <summary>Right Guard</summary>
    [DisplayName("Right Guard"), PositionSubGroup(PlayerPositionSubGroup.OG)]
    RG = 8,

    /// <summary>Right Tackle</summary>
    [DisplayName("Right Tackle"), PositionSubGroup(PlayerPositionSubGroup.OT)]
    RT = 9,

    /// <summary>Left End</summary>
    [DisplayName("Left End"), PositionSubGroup(PlayerPositionSubGroup.DE)]
    LE = 10,

    /// <summary>Right End</summary>
    [DisplayName("Right End"), PositionSubGroup(PlayerPositionSubGroup.DE)]
    RE = 11,

    /// <summary>Defensive Tackle</summary>
    [DisplayName("Defensive Tackle"), PositionSubGroup(PlayerPositionSubGroup.DT)]
    DT = 12,

    /// <summary>Left Outside Linebacker</summary>
    [DisplayName("Left Outside Linebacker"), PositionSubGroup(PlayerPositionSubGroup.OLB)]
    LOLB = 13,

    /// <summary>Middle Linebacker</summary>
    [DisplayName("Middle Linebacker"), PositionSubGroup(PlayerPositionSubGroup.ILB)]
    MLB = 14,

    /// <summary>Right Outside Linebacker</summary>
    [DisplayName("Right Outside Linebacker"), PositionSubGroup(PlayerPositionSubGroup.OLB)]
    ROLB = 15,

    /// <summary>Corner Back</summary>
    [DisplayName("Cornerback"), PositionSubGroup(PlayerPositionSubGroup.CB)]
    CB = 16,

    /// <summary>Free Safety</summary>
    [DisplayName("Free Safety"), PositionSubGroup(PlayerPositionSubGroup.S)]
    FS = 17,

    /// <summary>Strong Safety</summary>
    [DisplayName("Strong Safety"), PositionSubGroup(PlayerPositionSubGroup.S)]
    SS = 18,

    /// <summary>Kicker</summary>
    [DisplayName("Kicker"), PositionSubGroup(PlayerPositionSubGroup.K)]
    K = 19,

    /// <summary>Punter</summary>
    [DisplayName("Punter"), PositionSubGroup(PlayerPositionSubGroup.P)]
    P = 20,

    /// <summary>Kick Returner</summary>
    [DisplayName("Kick Returner"), PositionSubGroup(PlayerPositionSubGroup.DC)]
    KR = 21,

    /// <summary>Punt Returner</summary>
    [DisplayName("Punt Returner"), PositionSubGroup(PlayerPositionSubGroup.DC)]
    PR = 22,

    /// <summary>Kick Off Start</summary>
    [DisplayName("Kick Off Start"), PositionSubGroup(PlayerPositionSubGroup.DC)]
    KOS = 23,

    /// <summary>3rd Down Running Back</summary>
    [DisplayName("3rd Down Running Back"), PositionSubGroup(PlayerPositionSubGroup.DC)]
    DRB3 = 24,

    /// <summary>Long Snapper</summary>
    [DisplayName("Long Snapper"), PositionSubGroup(PlayerPositionSubGroup.DC)]
    LS = 25,
}

/// <summary>
/// The <c>PlayerPositionExtensions</c> class exposes extension functions for the <c>PlayerPosition</c> enum.
/// </summary>
public static class PlayerPositionExtensions
{
    /// <summary>
    /// Returns the position sub group the player position is a part of.
    /// </summary>
    /// <param name="value">The player position.</param>
    /// <returns>The player position sub group.</returns>
    public static PlayerPositionSubGroup PositionSubGroup(this PlayerPosition value) => value.GetAttribute<PositionSubGroupAttribute>().PositionSubGroup;
    
    /// <summary>
    /// Returns the position group the player position is a part of.
    /// </summary>
    /// <param name="value">The player position.</param>
    /// <returns>The player position group.</returns>
    public static PlayerPositionGroup PositionGroup(this PlayerPosition value) => value.PositionSubGroup().PositionGroup();

    /// <summary>
    /// Returns the flag indicating if the position is for use in the depth chart only (and not the roster).
    /// </summary>
    /// <param name="value">The player position.</param>
    /// <returns>The depth chart only flag.</returns>
    public static bool IsDepthChartOnly(this PlayerPosition value) => value.PositionSubGroup() == PlayerPositionSubGroup.DC;
}