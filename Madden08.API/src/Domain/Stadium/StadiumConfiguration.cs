using Madden08.API.Util;
using static Madden08.API.Domain.StadiumSection;

namespace Madden08.API.Domain;

/// <summary>
/// The stadium seating configuration for a custom stadium.
/// </summary>
/// <param name="EastSideline">The east sideline configuration.</param>
/// <param name="WestSideline">The west sideline configuration.</param>
/// <param name="NorthEndzone">The north endzone configuration.</param>
/// <param name="SouthEndzone">The south endzone configuration.</param>
/// <param name="NorthWestCorner">The north west corner configuration.</param>
/// <param name="NorthEastCorner">The north east corner configuration.</param>
/// <param name="SouthWestCorner">The south west corner configuration.</param>
/// <param name="SouthEastCorner">The south east corner configuration.</param>
public record StadiumConfiguration(
    StadiumConfiguration.Sideline EastSideline,
    StadiumConfiguration.Sideline WestSideline,
    StadiumConfiguration.Endzone NorthEndzone,
    StadiumConfiguration.Endzone SouthEndzone,
    StadiumConfiguration.Corner NorthWestCorner,
    StadiumConfiguration.Corner NorthEastCorner,
    StadiumConfiguration.Corner SouthWestCorner,
    StadiumConfiguration.Corner SouthEastCorner)
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
    /// </summary>
    /// <param name="modifier">The endzone modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithNorthEndzone(Func<Endzone, Endzone> modifier) => this with { NorthEndzone = modifier(NorthEndzone) };

    /// <summary>
    /// Update the south endzone configuration.
    /// </summary>
    /// <param name="modifier">The endzone modifier.</param>
    /// <returns>A new stadium configuration instance with the new sideline.</returns>
    public StadiumConfiguration WithSouthEndzone(Func<Endzone, Endzone> modifier) => this with { SouthEndzone = modifier(SouthEndzone) };

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
    public StadiumConfiguration WithSouthEastCorner(Func<Corner, Corner> modifier) => this with { SouthEastCorner = modifier(SouthEastCorner)};

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