using Madden08.API.Util;
using static Madden08.API.Domain.StadiumSection;

namespace Madden08.API.Domain;

/// <summary>
/// The stadium seating configuration for a custom stadium.
/// </summary>
/// <param name="EastSideline">The east sideline configuration.</param>
/// <param name="WestSideline">The west sideline configuration.</param>
/// <param name="NorthEndzone">The north end zone configuration.</param>
/// <param name="SouthEndzone">The south end zone configuration.</param>
/// <param name="NorthWestCorner">The northwest corner configuration.</param>
/// <param name="NorthEastCorner">The northeast corner configuration.</param>
/// <param name="SouthWestCorner">The southwest corner configuration.</param>
/// <param name="SouthEastCorner">The southeast corner configuration.</param>
/// <param name="LightType">The type of lights used by the stadium.</param>
/// <param name="RoofType">The type of roof used by the stadium.</param>
public record StadiumConfiguration(
    StadiumConfiguration.Sideline EastSideline,
    StadiumConfiguration.Sideline WestSideline,
    StadiumConfiguration.Endzone NorthEndzone,
    StadiumConfiguration.Endzone SouthEndzone,
    StadiumConfiguration.Corner NorthWestCorner,
    StadiumConfiguration.Corner NorthEastCorner,
    StadiumConfiguration.Corner SouthWestCorner,
    StadiumConfiguration.Corner SouthEastCorner,
    LightType LightType,
    RoofType RoofType)
{
    /// <summary>
    /// The calculated total capacity of the stadium with the current configuration.
    /// </summary>
    public Capacity Capacity => Capacity.StadiumBase.Adjust(
        EastSideline.CapacityAdjustment,
        WestSideline.CapacityAdjustment,
        NorthEndzone.CapacityAdjustment,
        SouthEndzone.CapacityAdjustment,
        NorthWestCorner.CapacityAdjustment,
        NorthEastCorner.CapacityAdjustment,
        SouthWestCorner.CapacityAdjustment,
        SouthEastCorner.CapacityAdjustment
    );

    /// <summary>
    /// Update the east sideline configuration.
    /// </summary>
    /// <param name="modifier">The sideline modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithEastSideline(Func<Sideline, Sideline> modifier) => this with { EastSideline = modifier(this.EastSideline) };

    /// <summary>
    /// Update the west sideline configuration.
    /// </summary>
    /// <param name="modifier">The sideline modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithWestSideline(Func<Sideline, Sideline> modifier) => this with { WestSideline = modifier(WestSideline) };

    /// <summary>
    /// Update the north endzone configuration.
    ///
    /// If the endzone is configured with an open ended tier 2 and the stadium currently has a roof, this will be changed to 4 lights.
    /// </summary>
    /// <param name="modifier">The endzone modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithNorthEndzone(Func<Endzone, Endzone> modifier)
    {
        var endzone = modifier(this.NorthEndzone);
        var roofType = DetermineRoofType(endzone);
        var lightType = DetermineLightType(endzone);
        return this with { NorthEndzone = modifier(NorthEndzone), RoofType = roofType, LightType = lightType };
    }

    /// <summary>
    /// Update the south endzone configuration.
    ///
    /// If the endzone is configured with an open ended tier 2 and the stadium currently has a roof, this will be changed to 4 lights.
    /// </summary>
    /// <param name="modifier">The endzone modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithSouthEndzone(Func<Endzone, Endzone> modifier)
    {
        var endzone = modifier(this.SouthEndzone);
        var roofType = DetermineRoofType(endzone);
        var lightType = DetermineLightType(endzone);
        return this with { SouthEndzone = endzone, RoofType = roofType, LightType = lightType };
    }

    /// <summary>
    /// Update the north west corner configuration.
    /// </summary>
    /// <param name="modifier">The corner modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithNorthWestCorner(Func<Corner, Corner> modifier) => this with { NorthWestCorner = modifier(NorthWestCorner) };

    /// <summary>
    /// Update the north east corner configuration.
    /// </summary>
    /// <param name="modifier">The corner modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithNorthEastCorner(Func<Corner, Corner> modifier) => this with { NorthEastCorner = modifier(NorthEastCorner) };

    /// <summary>
    /// Update the south west corner configuration.
    /// </summary>
    /// <param name="modifier">The corner modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithSouthWestCorner(Func<Corner, Corner> modifier) => this with { SouthWestCorner = modifier(SouthWestCorner) };

    /// <summary>
    /// Update the south east corner configuration.
    /// </summary>
    /// <param name="modifier">The corner modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithSouthEastCorner(Func<Corner, Corner> modifier) => this with { SouthEastCorner = modifier(SouthEastCorner) };

    /// <summary>
    /// Modify the stadium to use the defined light types.  This will remove any configured roof from the stadium configuration.
    /// </summary>
    /// <param name="lightType">The light type.</param>
    /// <returns>A new stadium configuration instance with the new light type.</returns>
    public StadiumConfiguration WithLights(LightType lightType) => this with { LightType = lightType, RoofType = RoofType.None };

    /// <summary>
    /// Modify the stadium to use the defined roof type.  This will remove any configured lights from the stadium configuration.
    /// </summary>
    /// <param name="roofType">The roof type.</param>
    /// <returns>A new stadium configuration instance with the new light type.</returns>
    /// <exception cref="InvalidOperationException">If you attempt to set a roof type when one of the endzones is open ended.</exception>
    public StadiumConfiguration WithRoof(RoofType roofType)
    {
        if (this.NorthEndzone.Tier2 == EndzoneTier2.OpenEnded || this.SouthEndzone.Tier2 == EndzoneTier2.OpenEnded)
            throw new InvalidOperationException("Cannot set a roof type when an endzone is configured as open ended.");
        return this with { RoofType = roofType, LightType = LightType.None };
    }

    private RoofType DetermineRoofType(Endzone endzone) => (this.RoofType != RoofType.None && endzone.Tier2 == EndzoneTier2.OpenEnded) ? RoofType.None : RoofType;
    private LightType DetermineLightType(Endzone endzone) => (this.RoofType != RoofType.None && endzone.Tier2 == EndzoneTier2.OpenEnded) ? LightType.FourLights : LightType;

    /// <summary>
    /// The <c>Corner</c> class represents a corner stadium configuration.
    /// </summary>
    /// <param name="CornerSection">The corner section .</param>
    public record Corner(StadiumSection.Corner CornerSection)
    {
        internal Capacity CapacityAdjustment => CornerSection.CapacityAdjustment();

        /// <summary>
        /// Update the with a new section configuration.
        /// </summary>
        /// <param name="corner">The corner section configuration.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Corner WithCorner(StadiumSection.Corner corner) => new(corner);
    }

    /// <summary>
    /// The <c>Endzone</c> class represents the configuration for an endzone stadium.
    /// </summary>
    /// <param name="Tier1">The lower tier configuration.</param>
    /// <param name="Tier2">The middle tier configuration.</param>
    /// <param name="Tier3">The upper tier configuration.</param>
    public record Endzone(EndzoneTier1 Tier1, EndzoneTier2 Tier2, EndzoneTier3 Tier3)
    {
        internal Capacity CapacityAdjustment => Tier1.CapacityAdjustment().Adjust(Tier2.CapacityAdjustment(), Tier3.CapacityAdjustment());

        /// <summary>
        /// Change the configuration for the lower tier.
        /// </summary>
        /// <param name="tier">The lower tier type.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Endzone WithTier1(EndzoneTier1 tier) => this with { Tier1 = tier };

        /// <summary>
        /// Change the configuration for the middle tier.
        /// </summary>
        /// <param name="tier">The middle tier type.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Endzone WithTier2(EndzoneTier2 tier) => this with { Tier2 = tier };

        /// <summary>
        /// Change the configuration for the upper tier.
        /// </summary>
        /// <param name="tier">The upper tier type.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Endzone WithTier3(EndzoneTier3 tier)
        {
            if (tier is EndzoneTier3.OpenScoreboard or EndzoneTier3.ClosedScoreboard && this.Tier2 != EndzoneTier2.OpenEnded)
                throw new InvalidOperationException($"You can only specific a [ {tier.DisplayName()} ] endzone tier 3 when tier 2 is [ {EndzoneTier2.OpenEnded.DisplayName()} ]");

            return this with { Tier3 = tier };
        }
    }

    /// <summary>
    /// The <c>Sizdeline</c> class represents the configuration for a sideline stadium.
    /// </summary>
    /// <param name="Tier1">The lower tier configuration.</param>
    /// <param name="Tier2">The middle tier configuration.</param>
    /// <param name="Tier3">The upper tier configuration.</param>
    public record Sideline(SidelineTier1 Tier1, SidelineTier2 Tier2, SidelineTier3 Tier3)
    {
        internal Capacity CapacityAdjustment => Tier1.CapacityAdjustment().Adjust(Tier2.CapacityAdjustment(), Tier3.CapacityAdjustment());

        /// <summary>
        /// Change the configuration for the lower tier.
        /// </summary>
        /// <param name="tier">The lower tier type.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Sideline WithTier1(SidelineTier1 tier) => this with { Tier1 = tier };

        /// <summary>
        /// Change the configuration for the middle tier.
        /// </summary>
        /// <param name="tier">The middle tier type.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Sideline WithTier2(SidelineTier2 tier) => this with { Tier2 = tier };

        /// <summary>
        /// Change the configuration for the upper tier.
        /// </summary>
        /// <param name="tier">The upper tier type.</param>
        /// <returns>The updated configuration with the new section.</returns>
        public Sideline WithTier3(SidelineTier3 tier) => this with { Tier3 = tier };
    }
}