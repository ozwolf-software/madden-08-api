using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>PlayerPositionGroup</c> enum represents the potential groups a position can be part of.
/// </summary>
// ReSharper disable InconsistentNaming
public enum PlayerPositionGroup
{
    /// <summary>Quarterbacks</summary>
    [DisplayName("Quarterbacks")]
    QB,
    /// <summary>Running Backs</summary>
    [DisplayName("Running Backs")]
    RB,
    /// <summary>Receivers</summary>
    [DisplayName("Receivers")]
    RC,
    /// <summary>Offensive Linemen</summary>
    [DisplayName("Offensive Linemen")]
    OL,
    /// <summary>Defensive Linemen</summary>
    [DisplayName("Defensive Linemen")]
    DL,
    /// <summary>Linebackers</summary>
    [DisplayName("Linebackers")]
    LB,
    /// <summary>Defensive Backs</summary>
    [DisplayName("Defensive Backs")]
    DB,
    /// <summary>Special Teams</summary>
    [DisplayName("Special Teams")]
    ST,
    /// <summary>Depth Chart Only</summary>
    [DisplayName("Depth Chart Only")]
    DC
}

/// <summary>
/// The <c>PositionGroupAttribute</c> class allows fields to be given a player position group attribute.
/// </summary>
/// <param name="group">The player position group.</param>
[AttributeUsage(AttributeTargets.Field)]
internal class PositionGroupAttribute(PlayerPositionGroup group) : Attribute
{
    /// <summary>The player position group value.</summary>
    public PlayerPositionGroup PositionGroup { get; set; } = group;
}