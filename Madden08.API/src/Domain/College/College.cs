using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>College</c> enum represents all the colleges mapped out in the Madden engine.
///
/// Exposes the <c>DisplayName()</c> extension;
/// </summary>

// ReSharper disable InconsistentNaming
public enum College
{
    /// <summary>Abilene Chr.</summary>
    [DisplayName("Abilene Chr.")] AbileneChr = 0,

    /// <summary>Air Force</summary>
    [DisplayName("Air Force")] AirForce = 1,

    /// <summary>Akron</summary>
    [DisplayName("Akron")] Akron = 2,

    /// <summary>Alabama</summary>
    [DisplayName("Alabama")] Alabama = 3,

    /// <summary>Alabama A&amp;M</summary>
    [DisplayName("Alabama A&M")] AlabamaAM = 4,

    /// <summary>Alabama St.</summary>
    [DisplayName("Alabama St.")] AlabamaSt = 5,

    /// <summary>Alcorn St.</summary>
    [DisplayName("Alcorn St.")] AlcornSt = 6,

    /// <summary>Appalach. St.</summary>
    [DisplayName("Appalach. St.")] AppalachSt = 7,

    /// <summary>Arizona</summary>
    [DisplayName("Arizona")] Arizona = 8,

    /// <summary>Arizona St.</summary>
    [DisplayName("Arizona St.")] ArizonaSt = 9,

    /// <summary>Arkansas</summary>
    [DisplayName("Arkansas")] Arkansas = 10,

    /// <summary>Arkansas P.B.</summary>
    [DisplayName("Arkansas P.B.")] ArkansasPB = 11,

    /// <summary>Arkansas St.</summary>
    [DisplayName("Arkansas St.")] ArkansasSt = 12,

    /// <summary>Army</summary>
    [DisplayName("Army")] Army = 13,

    /// <summary>Auburn</summary>
    [DisplayName("Auburn")] Auburn = 14,

    /// <summary>Austin Peay</summary>
    [DisplayName("Austin Peay")] AustinPeay = 15,

    /// <summary>Ball State</summary>
    [DisplayName("Ball State")] BallState = 16,

    /// <summary>Baylor</summary>
    [DisplayName("Baylor")] Baylor = 17,

    /// <summary>Beth Cookman</summary>
    [DisplayName("Beth Cookman")] BethCookman = 18,

    /// <summary>Boise State</summary>
    [DisplayName("Boise State")] BoiseState = 19,

    /// <summary>Boston Coll.</summary>
    [DisplayName("Boston Coll.")] BostonColl = 20,

    /// <summary>Bowl. Green</summary>
    [DisplayName("Bowl. Green")] BowlGreen = 21,

    /// <summary>Brown</summary>
    [DisplayName("Brown")] Brown = 22,

    /// <summary>Bucknell</summary>
    [DisplayName("Bucknell")] Bucknell = 23,

    /// <summary>Buffalo</summary>
    [DisplayName("Buffalo")] Buffalo = 24,

    /// <summary>Butler</summary>
    [DisplayName("Butler")] Butler = 25,

    /// <summary>BYU</summary>
    [DisplayName("BYU")] BYU = 26,

    /// <summary>Cal Poly SLO</summary>
    [DisplayName("Cal Poly SLO")] CalPolySLO = 27,

    /// <summary>California</summary>
    [DisplayName("California")] California = 28,

    /// <summary>Cal-Nrthridge</summary>
    [DisplayName("Cal-Nrthridge")] CalNrthridge = 29,

    /// <summary>Cal-Sacrmnto</summary>
    [DisplayName("Cal-Sacrmnto")] CalSacrmnto = 30,

    /// <summary>Canisius</summary>
    [DisplayName("Canisius")] Canisius = 31,

    /// <summary>Cent Conn St.</summary>
    [DisplayName("Cent Conn St.")] CentConnSt = 32,

    /// <summary>Central MI</summary>
    [DisplayName("Central MI")] CentralMI = 33,

    /// <summary>Central St Ohio</summary>
    [DisplayName("Central St Ohio")] CentralStOhio = 34,

    /// <summary>Charleston S.</summary>
    [DisplayName("Charleston S.")] CharlestonS = 35,

    /// <summary>Cincinnati</summary>
    [DisplayName("Cincinnati")] Cincinnati = 36,

    /// <summary>Citadel</summary>
    [DisplayName("Citadel")] Citadel = 37,

    /// <summary>Clemson</summary>
    [DisplayName("Clemson")] Clemson = 38,

    /// <summary>Clinch Valley</summary>
    [DisplayName("Clinch Valley")] ClinchValley = 39,

    /// <summary>Colgate</summary>
    [DisplayName("Colgate")] Colgate = 40,

    /// <summary>Colorado</summary>
    [DisplayName("Colorado")] Colorado = 41,

    /// <summary>Colorado St.</summary>
    [DisplayName("Colorado St.")] ColoradoSt = 42,

    /// <summary>Columbia</summary>
    [DisplayName("Columbia")] Columbia = 43,

    /// <summary>Cornell</summary>
    [DisplayName("Cornell")] Cornell = 44,

    /// <summary>Culver-Stockton</summary>
    [DisplayName("Culver-Stockton")] CulverStockton = 45,

    /// <summary>Dartmouth</summary>
    [DisplayName("Dartmouth")] Dartmouth = 46,

    /// <summary>Davidson</summary>
    [DisplayName("Davidson")] Davidson = 47,

    /// <summary>Dayton</summary>
    [DisplayName("Dayton")] Dayton = 48,

    /// <summary>Delaware</summary>
    [DisplayName("Delaware")] Delaware = 49,

    /// <summary>Delaware St.</summary>
    [DisplayName("Delaware St.")] DelawareSt = 50,

    /// <summary>Drake</summary>
    [DisplayName("Drake")] Drake = 51,

    /// <summary>Duke</summary>
    [DisplayName("Duke")] Duke = 52,

    /// <summary>Duquesne</summary>
    [DisplayName("Duquesne")] Duquesne = 53,

    /// <summary>E. Carolina</summary>
    [DisplayName("E. Carolina")] ECarolina = 54,

    /// <summary>E. Illinois</summary>
    [DisplayName("E. Illinois")] EIllinois = 55,

    /// <summary>E. Kentucky</summary>
    [DisplayName("E. Kentucky")] EKentucky = 56,

    /// <summary>E. Tenn. St.</summary>
    [DisplayName("E. Tenn. St.")] ETennSt = 57,

    /// <summary>East. Mich.</summary>
    [DisplayName("East. Mich.")] EastMich = 58,

    /// <summary>Eastern Wash.</summary>
    [DisplayName("Eastern Wash.")] EasternWash = 59,

    /// <summary>Elon College</summary>
    [DisplayName("Elon College")] ElonCollege = 60,

    /// <summary>Fairfield</summary>
    [DisplayName("Fairfield")] Fairfield = 61,

    /// <summary>Florida</summary>
    [DisplayName("Florida")] Florida = 62,

    /// <summary>Florida A&amp;M</summary>
    [DisplayName("Florida A&M")] FloridaAM = 63,

    /// <summary>Florida State</summary>
    [DisplayName("Florida State")] FloridaState = 64,

    /// <summary>Fordham</summary>
    [DisplayName("Fordham")] Fordham = 65,

    /// <summary>Fresno State</summary>
    [DisplayName("Fresno State")] FresnoState = 66,

    /// <summary>Furman</summary>
    [DisplayName("Furman")] Furman = 67,

    /// <summary>Ga. Southern</summary>
    [DisplayName("Ga. Southern")] GaSouthern = 68,

    /// <summary>Georgetown</summary>
    [DisplayName("Georgetown")] Georgetown = 69,

    /// <summary>Georgia</summary>
    [DisplayName("Georgia")] Georgia = 70,

    /// <summary>Georgia Tech</summary>
    [DisplayName("Georgia Tech")] GeorgiaTech = 71,

    /// <summary>Grambling St.</summary>
    [DisplayName("Grambling St.")] GramblingSt = 72,

    /// <summary>Grand Valley St.</summary>
    [DisplayName("Grand Valley St.")] GrandValleySt = 73,

    /// <summary>Hampton</summary>
    [DisplayName("Hampton")] Hampton = 74,

    /// <summary>Harvard</summary>
    [DisplayName("Harvard")] Harvard = 75,

    /// <summary>Hawaii</summary>
    [DisplayName("Hawaii")] Hawaii = 76,

    /// <summary>Henderson St.</summary>
    [DisplayName("Henderson St.")] HendersonSt = 77,

    /// <summary>Hofstra</summary>
    [DisplayName("Hofstra")] Hofstra = 78,

    /// <summary>Holy Cross</summary>
    [DisplayName("Holy Cross")] HolyCross = 79,

    /// <summary>Houston</summary>
    [DisplayName("Houston")] Houston = 80,

    /// <summary>Howard</summary>
    [DisplayName("Howard")] Howard = 81,

    /// <summary>Idaho</summary>
    [DisplayName("Idaho")] Idaho = 82,

    /// <summary>Idaho State</summary>
    [DisplayName("Idaho State")] IdahoState = 83,

    /// <summary>Illinois</summary>
    [DisplayName("Illinois")] Illinois = 84,

    /// <summary>Illinois St.</summary>
    [DisplayName("Illinois St.")] IllinoisSt = 85,

    /// <summary>Indiana</summary>
    [DisplayName("Indiana")] Indiana = 86,

    /// <summary>Indiana St.</summary>
    [DisplayName("Indiana St.")] IndianaSt = 87,

    /// <summary>Iona</summary>
    [DisplayName("Iona")] Iona = 88,

    /// <summary>Iowa</summary>
    [DisplayName("Iowa")] Iowa = 89,

    /// <summary>Iowa State</summary>
    [DisplayName("Iowa State")] IowaState = 90,

    /// <summary>J. Madison</summary>
    [DisplayName("J. Madison")] JMadison = 91,

    /// <summary>Jackson St.</summary>
    [DisplayName("Jackson St.")] JacksonSt = 92,

    /// <summary>Jacksonv. St.</summary>
    [DisplayName("Jacksonv. St.")] JacksonvSt = 93,

    /// <summary>John Carroll</summary>
    [DisplayName("John Carroll")] JohnCarroll = 94,

    /// <summary>Kansas</summary>
    [DisplayName("Kansas")] Kansas = 95,

    /// <summary>Kansas State</summary>
    [DisplayName("Kansas State")] KansasState = 96,

    /// <summary>Kent State</summary>
    [DisplayName("Kent State")] KentState = 97,

    /// <summary>Kentucky</summary>
    [DisplayName("Kentucky")] Kentucky = 98,

    /// <summary>Kutztown</summary>
    [DisplayName("Kutztown")] Kutztown = 99,

    /// <summary>La Salle</summary>
    [DisplayName("La Salle")] LaSalle = 100,

    /// <summary>LA. Tech</summary>
    [DisplayName("LA. Tech")] LATech = 101,

    /// <summary>Lambuth</summary>
    [DisplayName("Lambuth")] Lambuth = 102,

    /// <summary>Lehigh</summary>
    [DisplayName("Lehigh")] Lehigh = 103,

    /// <summary>Liberty</summary>
    [DisplayName("Liberty")] Liberty = 104,

    /// <summary>Louisville</summary>
    [DisplayName("Louisville")] Louisville = 105,

    /// <summary>LSU</summary>
    [DisplayName("LSU")] LSU = 106,

    /// <summary>M. Valley St.</summary>
    [DisplayName("M. Valley St.")] MValleySt = 107,

    /// <summary>Maine</summary>
    [DisplayName("Maine")] Maine = 108,

    /// <summary>Marist</summary>
    [DisplayName("Marist")] Marist = 109,

    /// <summary>Marshall</summary>
    [DisplayName("Marshall")] Marshall = 110,

    /// <summary>Maryland</summary>
    [DisplayName("Maryland")] Maryland = 111,

    /// <summary>Massachusetts</summary>
    [DisplayName("Massachusetts")] Massachusetts = 112,

    /// <summary>McNeese St.</summary>
    [DisplayName("McNeese St.")] McNeeseSt = 113,

    /// <summary>Memphis</summary>
    [DisplayName("Memphis")] Memphis = 114,

    /// <summary>Miami</summary>
    [DisplayName("Miami")] Miami = 115,

    /// <summary>Miami Univ.</summary>
    [DisplayName("Miami Univ.")] MiamiUniv = 116,

    /// <summary>Michigan</summary>
    [DisplayName("Michigan")] Michigan = 117,

    /// <summary>Michigan St.</summary>
    [DisplayName("Michigan St.")] MichiganSt = 118,

    /// <summary>Mid Tenn St.</summary>
    [DisplayName("Mid Tenn St.")] MidTennSt = 119,

    /// <summary>Minnesota</summary>
    [DisplayName("Minnesota")] Minnesota = 120,

    /// <summary>Miss. State</summary>
    [DisplayName("Miss. State")] MissState = 121,

    /// <summary>Missouri</summary>
    [DisplayName("Missouri")] Missouri = 122,

    /// <summary>Monmouth</summary>
    [DisplayName("Monmouth")] Monmouth = 123,

    /// <summary>Montana</summary>
    [DisplayName("Montana")] Montana = 124,

    /// <summary>Montana State</summary>
    [DisplayName("Montana State")] MontanaState = 125,

    /// <summary>Morehead St.</summary>
    [DisplayName("Morehead St.")] MoreheadSt = 126,

    /// <summary>Morehouse</summary>
    [DisplayName("Morehouse")] Morehouse = 127,

    /// <summary>Morgan St.</summary>
    [DisplayName("Morgan St.")] MorganSt = 128,

    /// <summary>Morris Brown</summary>
    [DisplayName("Morris Brown")] MorrisBrown = 129,

    /// <summary>Mt S. Antonio</summary>
    [DisplayName("Mt S. Antonio")] MtSAntonio = 130,

    /// <summary>Murray State</summary>
    [DisplayName("Murray State")] MurrayState = 131,

    /// <summary>N. Alabama</summary>
    [DisplayName("N. Alabama")] NAlabama = 132,

    /// <summary>N. Arizona</summary>
    [DisplayName("N. Arizona")] NArizona = 133,

    /// <summary>N. Car A&amp;T</summary>
    [DisplayName("N. Car A&T")] NCarAT = 134,

    /// <summary>N. Carolina</summary>
    [DisplayName("N. Carolina")] NCarolina = 135,

    /// <summary>N. Colorado</summary>
    [DisplayName("N. Colorado")] NColorado = 136,

    /// <summary>N. Illinois</summary>
    [DisplayName("N. Illinois")] NIllinois = 137,

    /// <summary>N.C. State</summary>
    [DisplayName("N.C. State")] NCState = 138,

    /// <summary>Navy</summary>
    [DisplayName("Navy")] Navy = 139,

    /// <summary>NC Central</summary>
    [DisplayName("NC Central")] NCCentral = 140,

    /// <summary>Nebr.-Omaha</summary>
    [DisplayName("Nebr.-Omaha")] NebrOmaha = 141,

    /// <summary>Nebraska</summary>
    [DisplayName("Nebraska")] Nebraska = 142,

    /// <summary>Nevada</summary>
    [DisplayName("Nevada")] Nevada = 143,

    /// <summary>New Mex. St.</summary>
    [DisplayName("New Mex. St.")] NewMexSt = 144,

    /// <summary>New Mexico</summary>
    [DisplayName("New Mexico")] NewMexico = 145,

    /// <summary>Nicholls St.</summary>
    [DisplayName("Nicholls St.")] NichollsSt = 146,

    /// <summary>Norfolk State</summary>
    [DisplayName("Norfolk State")] NorfolkState = 147,

    /// <summary>North Texas</summary>
    [DisplayName("North Texas")] NorthTexas = 148,

    /// <summary>Northeastern</summary>
    [DisplayName("Northeastern")] Northeastern = 149,

    /// <summary>Northern Iowa</summary>
    [DisplayName("Northern Iowa")] NorthernIowa = 150,

    /// <summary>Northwestern</summary>
    [DisplayName("Northwestern")] Northwestern = 151,

    /// <summary>Notre Dame</summary>
    [DisplayName("Notre Dame")] NotreDame = 152,

    /// <summary>NW Oklahoma St.</summary>
    [DisplayName("NW Oklahoma St.")] NWOklahomaSt = 153,

    /// <summary>N'western St.</summary>
    [DisplayName("N'western St.")] NwesternSt = 154,

    /// <summary>Ohio</summary>
    [DisplayName("Ohio")] Ohio = 155,

    /// <summary>Ohio State</summary>
    [DisplayName("Ohio State")] OhioState = 156,

    /// <summary>Oklahoma</summary>
    [DisplayName("Oklahoma")] Oklahoma = 157,

    /// <summary>Oklahoma St.</summary>
    [DisplayName("Oklahoma St.")] OklahomaSt = 158,

    /// <summary>Ole Miss</summary>
    [DisplayName("Ole Miss")] OleMiss = 159,

    /// <summary>Oregon</summary>
    [DisplayName("Oregon")] Oregon = 160,

    /// <summary>Oregon State</summary>
    [DisplayName("Oregon State")] OregonState = 161,

    /// <summary>P. View A&amp;M</summary>
    [DisplayName("P. View A&M")] PViewAM = 162,

    /// <summary>Penn</summary>
    [DisplayName("Penn")] Penn = 163,

    /// <summary>Penn State</summary>
    [DisplayName("Penn State")] PennState = 164,

    /// <summary>Pittsburg St.</summary>
    [DisplayName("Pittsburg St.")] PittsburgSt = 165,

    /// <summary>Pittsburgh</summary>
    [DisplayName("Pittsburgh")] Pittsburgh = 166,

    /// <summary>Portland St.</summary>
    [DisplayName("Portland St.")] PortlandSt = 167,

    /// <summary>Princeton</summary>
    [DisplayName("Princeton")] Princeton = 168,

    /// <summary>Purdue</summary>
    [DisplayName("Purdue")] Purdue = 169,

    /// <summary>Rhode Island</summary>
    [DisplayName("Rhode Island")] RhodeIsland = 170,

    /// <summary>Rice</summary>
    [DisplayName("Rice")] Rice = 171,

    /// <summary>Richmond</summary>
    [DisplayName("Richmond")] Richmond = 172,

    /// <summary>Robert Morris</summary>
    [DisplayName("Robert Morris")] RobertMorris = 173,

    /// <summary>Rowan</summary>
    [DisplayName("Rowan")] Rowan = 174,

    /// <summary>Rutgers</summary>
    [DisplayName("Rutgers")] Rutgers = 175,

    /// <summary>S. Carolina</summary>
    [DisplayName("S. Carolina")] SCarolina = 176,

    /// <summary>S. Dakota St.</summary>
    [DisplayName("S. Dakota St.")] SDakotaSt = 177,

    /// <summary>S. Illinois</summary>
    [DisplayName("S. Illinois")] SIllinois = 178,

    /// <summary>S.C. State</summary>
    [DisplayName("S.C. State")] SCState = 179,

    /// <summary>S.D. State</summary>
    [DisplayName("S.D. State")] SDState = 180,

    /// <summary>S.F. Austin</summary>
    [DisplayName("S.F. Austin")] SFAustin = 181,

    /// <summary>Sacred Heart</summary>
    [DisplayName("Sacred Heart")] SacredHeart = 182,

    /// <summary>Sam Houston</summary>
    [DisplayName("Sam Houston")] SamHouston = 183,

    /// <summary>Samford</summary>
    [DisplayName("Samford")] Samford = 184,

    /// <summary>San Jose St.</summary>
    [DisplayName("San Jose St.")] SanJoseSt = 185,

    /// <summary>Savannah St.</summary>
    [DisplayName("Savannah St.")] SavannahSt = 186,

    /// <summary>SE Missouri</summary>
    [DisplayName("SE Missouri")] SEMissouri = 187,

    /// <summary>SE Missouri St.</summary>
    [DisplayName("SE Missouri St.")] SEMissouriSt = 188,

    /// <summary>Shippensburg</summary>
    [DisplayName("Shippensburg")] Shippensburg = 189,

    /// <summary>Siena</summary>
    [DisplayName("Siena")] Siena = 190,

    /// <summary>Simon Fraser</summary>
    [DisplayName("Simon Fraser")] SimonFraser = 191,

    /// <summary>SMU</summary>
    [DisplayName("SMU")] SMU = 192,

    /// <summary>Southern</summary>
    [DisplayName("Southern")] Southern = 193,

    /// <summary>Southern Miss</summary>
    [DisplayName("Southern Miss")] SouthernMiss = 194,

    /// <summary>Southern Utah</summary>
    [DisplayName("Southern Utah")] SouthernUtah = 195,

    /// <summary>St. Francis</summary>
    [DisplayName("St. Francis")] StFrancis = 196,

    /// <summary>St. John's</summary>
    [DisplayName("St. John's")] StJohns = 197,

    /// <summary>St. Mary's</summary>
    [DisplayName("St. Mary's")] StMarys = 198,

    /// <summary>St. Peters</summary>
    [DisplayName("St. Peters")] StPeters = 199,

    /// <summary>Stanford</summary>
    [DisplayName("Stanford")] Stanford = 200,

    /// <summary>Stony Brook</summary>
    [DisplayName("Stony Brook")] StonyBrook = 201,

    /// <summary>SUNY Albany</summary>
    [DisplayName("SUNY Albany")] SUNYAlbany = 202,

    /// <summary>SW Miss St</summary>
    [DisplayName("SW Miss St")] SWMissSt = 203,

    /// <summary>SW Texas St.</summary>
    [DisplayName("SW Texas St.")] SWTexasSt = 204,

    /// <summary>Syracuse</summary>
    [DisplayName("Syracuse")] Syracuse = 205,

    /// <summary>T A&amp;M K'ville</summary>
    [DisplayName("T A&M K'ville")] TAMKville = 206,

    /// <summary>TCU</summary>
    [DisplayName("TCU")] TCU = 207,

    /// <summary>Temple</summary>
    [DisplayName("Temple")] Temple = 208,

    /// <summary>Tenn. Tech</summary>
    [DisplayName("Tenn. Tech")] TennTech = 209,

    /// <summary>Tenn-Chat</summary>
    [DisplayName("Tenn-Chat")] TennChat = 210,

    /// <summary>Tennessee</summary>
    [DisplayName("Tennessee")] Tennessee = 211,

    /// <summary>Tennessee St.</summary>
    [DisplayName("Tennessee St.")] TennesseeSt = 212,

    /// <summary>Tenn-Martin</summary>
    [DisplayName("Tenn-Martin")] TennMartin = 213,

    /// <summary>Texas</summary>
    [DisplayName("Texas")] Texas = 214,

    /// <summary>Texas A&amp;M</summary>
    [DisplayName("Texas A&M")] TexasAM = 215,

    /// <summary>Texas South.</summary>
    [DisplayName("Texas South.")] TexasSouth = 216,

    /// <summary>Texas Tech</summary>
    [DisplayName("Texas Tech")] TexasTech = 217,

    /// <summary>Toledo</summary>
    [DisplayName("Toledo")] Toledo = 218,

    /// <summary>Towson State</summary>
    [DisplayName("Towson State")] TowsonState = 219,

    /// <summary>Troy State</summary>
    [DisplayName("Troy State")] TroyState = 220,

    /// <summary>Tulane</summary>
    [DisplayName("Tulane")] Tulane = 221,

    /// <summary>Tulsa</summary>
    [DisplayName("Tulsa")] Tulsa = 222,

    /// <summary>Tuskegee</summary>
    [DisplayName("Tuskegee")] Tuskegee = 223,

    /// <summary>UAB</summary>
    [DisplayName("UAB")] UAB = 224,

    /// <summary>UCF</summary>
    [DisplayName("UCF")] UCF = 225,

    /// <summary>UCLA</summary>
    [DisplayName("UCLA")] UCLA = 226,

    /// <summary>UConn</summary>
    [DisplayName("UConn")] UConn = 227,

    /// <summary>UL Lafayette</summary>
    [DisplayName("UL Lafayette")] ULLafayette = 228,

    /// <summary>UL Monroe</summary>
    [DisplayName("UL Monroe")] ULMonroe = 229,

    /// <summary>UNLV</summary>
    [DisplayName("UNLV")] UNLV = 230,

    /// <summary>USC</summary>
    [DisplayName("USC")] USC = 231,

    /// <summary>USF</summary>
    [DisplayName("USF")] USF = 232,

    /// <summary>Utah</summary>
    [DisplayName("Utah")] Utah = 233,

    /// <summary>Utah State</summary>
    [DisplayName("Utah State")] UtahState = 234,

    /// <summary>UTEP</summary>
    [DisplayName("UTEP")] UTEP = 235,

    /// <summary>Valdosta St.</summary>
    [DisplayName("Valdosta St.")] ValdostaSt = 236,

    /// <summary>Valparaiso</summary>
    [DisplayName("Valparaiso")] Valparaiso = 237,

    /// <summary>Vanderbilt</summary>
    [DisplayName("Vanderbilt")] Vanderbilt = 238,

    /// <summary>Villanova</summary>
    [DisplayName("Villanova")] Villanova = 239,

    /// <summary>Virginia</summary>
    [DisplayName("Virginia")] Virginia = 240,

    /// <summary>Virginia Tech</summary>
    [DisplayName("Virginia Tech")] VirginiaTech = 241,

    /// <summary>VMI</summary>
    [DisplayName("VMI")] VMI = 242,

    /// <summary>W. Carolina</summary>
    [DisplayName("W. Carolina")] WCarolina = 243,

    /// <summary>W. Illinois</summary>
    [DisplayName("W. Illinois")] WIllinois = 244,

    /// <summary>W. Kentucky</summary>
    [DisplayName("W. Kentucky")] WKentucky = 245,

    /// <summary>W. Michigan</summary>
    [DisplayName("W. Michigan")] WMichigan = 246,

    /// <summary>W. Texas A&amp;M</summary>
    [DisplayName("W. Texas A&M")] WTexasAM = 247,

    /// <summary>Wagner</summary>
    [DisplayName("Wagner")] Wagner = 248,

    /// <summary>Wake Forest</summary>
    [DisplayName("Wake Forest")] WakeForest = 249,

    /// <summary>Walla Walla</summary>
    [DisplayName("Walla Walla")] WallaWalla = 250,

    /// <summary>Wash. St.</summary>
    [DisplayName("Wash. St.")] WashSt = 251,

    /// <summary>Washington</summary>
    [DisplayName("Washington")] Washington = 252,

    /// <summary>Weber State</summary>
    [DisplayName("Weber State")] WeberState = 253,

    /// <summary>West Virginia</summary>
    [DisplayName("West Virginia")] WestVirginia = 254,

    /// <summary>Westminster</summary>
    [DisplayName("Westminster")] Westminster = 255,

    /// <summary>Will. &amp; Mary</summary>
    [DisplayName("Will. & Mary")] WillMary = 256,

    /// <summary>Winston Salem</summary>
    [DisplayName("Winston Salem")] WinstonSalem = 257,

    /// <summary>Wisconsin</summary>
    [DisplayName("Wisconsin")] Wisconsin = 258,

    /// <summary>Wofford</summary>
    [DisplayName("Wofford")] Wofford = 259,

    /// <summary>Wyoming</summary>
    [DisplayName("Wyoming")] Wyoming = 260,

    /// <summary>Yale</summary>
    [DisplayName("Yale")] Yale = 261,

    /// <summary>Youngstwn St.</summary>
    [DisplayName("Youngstwn St.")] YoungstwnSt = 262,

    /// <summary>Sonoma St.</summary>
    [DisplayName("Sonoma St.")] SonomaSt = 263,

    /// <summary>No College</summary>
    [DisplayName("No College")] NoCollege = 264,

    /// <summary>N/A</summary>
    [DisplayName("N/A")] NA = 265,

    /// <summary>New Hampshire</summary>
    [DisplayName("New Hampshire")] NewHampshire = 266,

    /// <summary>UW Lacrosse</summary>
    [DisplayName("UW Lacrosse")] UWLacrosse = 267,

    /// <summary>Hastings College</summary>
    [DisplayName("Hastings College")] HastingsCollege = 268,

    /// <summary>Midwestern St.</summary>
    [DisplayName("Midwestern St.")] MidwesternSt = 269,

    /// <summary>North Dakota</summary>
    [DisplayName("North Dakota")] NorthDakota = 270,

    /// <summary>Wayne State</summary>
    [DisplayName("Wayne State")] WayneState = 271,

    /// <summary>UW Stevens Pt.</summary>
    [DisplayName("UW Stevens Pt.")] UWStevensPt = 272,

    /// <summary>Indiana(Penn.)</summary>
    [DisplayName("Indiana(Penn.)")] IndianaPenn = 273,

    /// <summary>Saginaw Valley</summary>
    [DisplayName("Saginaw Valley")] SaginawValley = 274,

    /// <summary>Central St.(OK)</summary>
    [DisplayName("Central St.(OK)")] CentralStOK = 275,

    /// <summary>Emporia State</summary>
    [DisplayName("Emporia State")] EmporiaState = 276,
}