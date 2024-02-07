using Madden08.API.Domain.Common;
using Madden08.API.Util;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>PlayerPositionSubGroup</c> enum represents the various sub-groups a player position can be in.
/// </summary>
public enum PlayerPositionSubGroup
{
    /// <summary>Quarterbacks</summary>
    [DisplayName("Quarterbacks"), PositionGroup(PlayerPositionGroup.QB)]
    QB,
    /// <summary>Half Backs</summary>
    [DisplayName("Half Backs"), PositionGroup(PlayerPositionGroup.RB)]
    HB,
    /// <summary>Full Backs</summary>
    [DisplayName("Full Backs"), PositionGroup(PlayerPositionGroup.RB)]
    FB,
    /// <summary>Wide Receivers</summary>
    [DisplayName("Wide Receivers"), PositionGroup(PlayerPositionGroup.RC)]
    WR,
    /// <summary>Tight Ends</summary>
    [DisplayName("Tight Ends"), PositionGroup(PlayerPositionGroup.RC)]
    TE,
    /// <summary>Offensive Tackles</summary>
    [DisplayName("Offensive Tackles"), PositionGroup(PlayerPositionGroup.OL)]
    OT,
    /// <summary>Offensive Guards</summary>
    [DisplayName("Offensive Guards"), PositionGroup(PlayerPositionGroup.OL)]
    OG,
    /// <summary>Centers</summary>
    [DisplayName("Centers"), PositionGroup(PlayerPositionGroup.OL)]
    C,
    /// <summary>Defensive Ends</summary>
    [DisplayName("Defensive Ends"), PositionGroup(PlayerPositionGroup.DL)]
    DE,
    /// <summary>Defensive Tackles</summary>
    [DisplayName("Defensive Tackles"), PositionGroup(PlayerPositionGroup.DL)]
    DT,
    /// <summary>Outside Linebackers</summary>
    [DisplayName("Outside Linebackers"), PositionGroup(PlayerPositionGroup.LB)]
    OLB,
    /// <summary>Inside Linebackers</summary>
    [DisplayName("Inside Linebackers"), PositionGroup(PlayerPositionGroup.LB)]
    ILB,
    /// <summary>Cornerbacks</summary>
    [DisplayName("Cornerbacks"), PositionGroup(PlayerPositionGroup.DB)]
    CB,
    /// <summary>Safeties</summary>
    [DisplayName("Safeties"), PositionGroup(PlayerPositionGroup.DB)]
    S,
    /// <summary>Kickers</summary>
    [DisplayName("Kickers"), PositionGroup(PlayerPositionGroup.ST)]
    K,
    /// <summary>Punters</summary>
    [DisplayName("Punters"), PositionGroup(PlayerPositionGroup.ST)]
    P,
    /// <summary>Depth Chart Only</summary>
    [DisplayName("Depth Chart Only"), PositionGroup(PlayerPositionGroup.DC)]
    DC
}

/// <summary>
/// The <c>PositionSubGroupAttribute</c> allows fields to given a position sub group attribute.
/// </summary>
/// <param name="subGroup">The position sub group.</param>
[AttributeUsage(AttributeTargets.Field)]
internal class PositionSubGroupAttribute(PlayerPositionSubGroup subGroup): Attribute
{
    /// <summary>The position sub group.</summary>
    public PlayerPositionSubGroup PositionSubGroup { get; set; } = subGroup;
}

/// <summary>
/// The <c>PlayerPositionSubGroupExtensions</c> class exposes extra extension functions for the <c>PlayerPositonSubGroup</c> enum.
/// </summary>
public static class PlayerPositionSubGroupExtensions
{
    /// <summary>
    /// Return the player position group attribute on the given enum.
    /// </summary>
    /// <param name="group">The enum instance.</param>
    /// <returns>The player position group attribute value.</returns>
    public static PlayerPositionGroup PositionGroup(this PlayerPositionSubGroup group) => group.GetAttribute<PositionGroupAttribute>().PositionGroup;
}