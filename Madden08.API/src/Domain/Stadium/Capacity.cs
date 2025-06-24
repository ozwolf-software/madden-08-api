using Madden08.API.Util;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>Capacity</c> record represents the total capacity by seat type for a created stadium.
/// </summary>
/// <param name="UpperEndZone">The upper end zone seating.</param>
/// <param name="LowerLevel">The lower level seating.</param>
/// <param name="LuxuryBoxes">The luxury box capacity.</param>
/// <param name="MidLevel">The mid level seating.</param>
/// <param name="UpperLevel">The upper side seating.</param>
/// <param name="ClubSeats">The total club seats.</param>
public record Capacity(int UpperEndZone, int LowerLevel, int LuxuryBoxes, int MidLevel, int UpperLevel, int ClubSeats)
{
    /// <summary>
    /// The total capacity of a stadium.
    /// </summary>
    public int Total => UpperEndZone + LowerLevel + LuxuryBoxes + MidLevel + UpperLevel + ClubSeats;

    internal static readonly Capacity StadiumBase = new(8800, 28150, 0, 24200, 20850, 1440);

    internal Capacity Adjust(params Capacity[] adjustments) => new Capacity(
        UpperEndZone: this.UpperEndZone + adjustments.Sum(a => a.UpperEndZone),
        LowerLevel: this.LowerLevel + adjustments.Sum(a => a.LowerLevel),
        LuxuryBoxes: this.LuxuryBoxes + adjustments.Sum(a => a.LuxuryBoxes),
        MidLevel: this.MidLevel + adjustments.Sum(a => a.MidLevel),
        UpperLevel: this.UpperLevel + adjustments.Sum(a => a.UpperLevel),
        ClubSeats: this.ClubSeats + adjustments.Sum(a => a.ClubSeats)
    );
}

[AttributeUsage(AttributeTargets.Field)]
internal class CapacityAdjustmentAttribute : Attribute
{
    public int UpperEndZone { get; set; } = 0;
    public int LowerLevel { get; set; } = 0;
    public int LuxuryBoxes { get; set; } = 0;
    public int MidLevel { get; set; } = 0;
    public int UpperLevel { get; set; } = 0;
    public int ClubSeats { get; set; } = 0;

    internal Capacity Adjustment => new(UpperEndZone, LowerLevel, LuxuryBoxes, MidLevel, UpperLevel, UpperEndZone);
}

internal static class CapacityAdjustmentAttributeExtensions
{
    internal static Capacity CapacityAdjustment(this StadiumSection.Corner value) => value
        .GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;

    internal static Capacity CapacityAdjustment(this StadiumSection.EndzoneTier1 value) =>
        value.GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;

    internal static Capacity CapacityAdjustment(this StadiumSection.EndzoneTier2 value) =>
        value.GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;

    internal static Capacity CapacityAdjustment(this StadiumSection.EndzoneTier3 value) =>
        value.GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;

    internal static Capacity CapacityAdjustment(this StadiumSection.SidelineTier1 value) =>
        value.GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;

    internal static Capacity CapacityAdjustment(this StadiumSection.SidelineTier2 value) =>
        value.GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;

    internal static Capacity CapacityAdjustment(this StadiumSection.SidelineTier3 value) =>
        value.GetAttribute(new CapacityAdjustmentAttribute()).Adjustment;
}