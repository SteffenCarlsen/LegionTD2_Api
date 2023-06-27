using System.ComponentModel;

namespace TaF.LegionTD2Api.ApiModel;
public enum PlayerSorting
{
    [Description("overallElo")]
    OverallElo,
    [Description("overallPeakElo")]
    OverallPeakElo,
    [Description("secondsPlayed")]
    SecondsPlayed,
    [Description("gamesWithoutCard")]
    GamesWithoutCard,
    [Description("gamesPlayed")]
    GamesPlayed,
    [Description("totalXp")]
    TotalXp,
    [Description("ladderPoints")]
    LadderPoints,
    [Description("classicElo")]
    ClassicElo,
    [Description("classicPeakElo")]
    ClassicPeakElo,
    [Description("wins")]
    Wins,
    [Description("losses")]
    Losses
}