using Madden08.API.Util;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>PlayerAttributes</c> class represents a players current ratings.
/// </summary>
/// <param name="OVR">The player overall.</param>
/// <param name="SPD">The player speed.</param>
/// <param name="STR">The player strength.</param>
/// <param name="AWR">The player awareness.</param>
/// <param name="AGI">The player agility</param>
/// <param name="ACC">The player acceleration.</param>
/// <param name="CTH">The player catching.</param>
/// <param name="CAR">The player carrying.</param>
/// <param name="JMP">The player jumping.</param>
/// <param name="BTK">The player break tackle.</param>
/// <param name="TAK">The player tackling.</param>
/// <param name="THP">The player throw power.</param>
/// <param name="THA">The player throw accuracy.</param>
/// <param name="PBK">The player pass blocking.</param>
/// <param name="RBK">The player run blocking.</param>
/// <param name="KPW">The player kick power.</param>
/// <param name="KAC">The player kick accuracy.</param>
/// <param name="STA">The player stamina.</param>
/// <param name="INJ">The player injury level.</param>
/// <param name="IMP">The player impact.</param>
/// <param name="TGH">The player toughness.</param>
/// <param name="KR">The player kick return.</param>
public record PlayerAttributes(int OVR, int SPD, int STR, int AWR, int AGI, int ACC, int CTH, int CAR, int JMP, int BTK, int TAK, int THP, int THA, int PBK, int RBK, int KPW, int KAC, int STA, int INJ, int IMP, int TGH, int KR)
{
    /// <summary>
    /// Change the player overall.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithOVR(int rating) => this with { OVR = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustOVR(int adjustment) => this.WithOVR(OVR + adjustment);

    /// <summary>
    /// Change the player speed.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithSPD(int rating) => this with { SPD = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustSPD(int adjustment) => this.WithSPD(SPD + adjustment);

    /// <summary>
    /// Change the player strength.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithSTR(int rating) => this with { STR = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustSTR(int adjustment) => this.WithSTR(STR + adjustment);

    /// <summary>
    /// Change the player awareness.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithAWR(int rating) => this with { AWR = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustAWR(int adjustment) => this.WithAWR(AWR + adjustment);

    /// <summary>
    /// Change the player agility.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithAGI(int rating) => this with { AGI = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustAGI(int adjustment) => this.WithAGI(AGI + adjustment);

    /// <summary>
    /// Change the player acceleration.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithACC(int rating) => this with { ACC = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustACC(int adjustment) => this.WithACC(ACC + adjustment);

    /// <summary>
    /// Change the player catching.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithCTH(int rating) => this with { CTH = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustCTH(int adjustment) => this.WithCTH(CTH + adjustment);

    /// <summary>
    /// Change the player carrying.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithCAR(int rating) => this with { CAR = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustCAR(int adjustment) => this.WithCAR(CAR + adjustment);

    /// <summary>
    /// Change the player jumping.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithJMP(int rating) => this with { JMP = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustJMP(int adjustment) => this.WithJMP(JMP + adjustment);

    /// <summary>
    /// Change the player break tackle.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithBTK(int rating) => this with { BTK = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustBTK(int adjustment) => this.WithBTK(BTK + adjustment);

    /// <summary>
    /// Change the player tackling.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithTAK(int rating) => this with { TAK = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustTAK(int adjustment) => this.WithTAK(TAK + adjustment);

    /// <summary>
    /// Change the player throw power.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithTHP(int rating) => this with { THP = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustTHP(int adjustment) => this.WithTHP(THP + adjustment);

    /// <summary>
    /// Change the player throw accuracy.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithTHA(int rating) => this with { THA = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustTHA(int adjustment) => this.WithTHA(THA + adjustment);

    /// <summary>
    /// Change the player pass blocking.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithPBK(int rating) => this with { PBK = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustPBK(int adjustment) => this.WithPBK(PBK + adjustment);

    /// <summary>
    /// Change the player run blocking.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithRBK(int rating) => this with { RBK = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustRBK(int adjustment) => this.WithRBK(RBK + adjustment);

    /// <summary>
    /// Change the player kick power.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithKPW(int rating) => this with { KPW = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustKPW(int adjustment) => this.WithKPW(KPW + adjustment);

    /// <summary>
    /// Change the player kick accuracy.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithKAC(int rating) => this with { KAC = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustKAC(int adjustment) => this.WithKAC(KAC + adjustment);

    /// <summary>
    /// Change the player stamina.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithSTA(int rating) => this with { STA = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustSTA(int adjustment) => this.WithSTA(STA + adjustment);

    /// <summary>
    /// Change the player injury level.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithINJ(int rating) => this with { INJ = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustINJ(int adjustment) => this.WithINJ(INJ + adjustment);

    /// <summary>
    /// Change the player impact.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithIMP(int rating) => this with { IMP = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustIMP(int adjustment) => this.WithIMP(IMP + adjustment);

    /// <summary>
    /// Change the player toughness.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithTGH(int rating) => this with { TGH = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustTGH(int adjustment) => this.WithTGH(TGH + adjustment);

    /// <summary>
    /// Change the player kick return.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>A new player attributes instance with the updated rating.</returns>
    public PlayerAttributes WithKR(int rating) => this with { KR = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Adjust the rating by the given amount.
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new player attributes instance with the adjusted rating.</returns>
    public PlayerAttributes AdjustKR(int adjustment) => this.WithKR(KR + adjustment);
}