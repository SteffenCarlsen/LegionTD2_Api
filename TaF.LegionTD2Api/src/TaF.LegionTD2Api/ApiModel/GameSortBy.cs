using System.ComponentModel;

namespace TaF.LegionTD2Api.ApiModel;

public enum GameSortBy
{
    [Description("date")]
    Date,
    [Description("gameElo")]
    GameElo,
    [Description("wave")]
    Wave,
    [Description("queueType")]
    QueueType,
    [Description("gameLength")]
    GameLength
}