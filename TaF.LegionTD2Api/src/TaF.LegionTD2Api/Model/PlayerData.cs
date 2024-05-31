using System.Collections.Generic;
using Newtonsoft.Json;

namespace TaF.LegionTD2Api.Model;

public class PlayersData
{
    [JsonProperty("playerId")] public string PlayerId { get; set; }

    [JsonProperty("playerName")] public string PlayerName { get; set; }

    [JsonProperty("playerSlot")] public int? PlayerSlot { get; set; }

    [JsonProperty("legion")] public string Legion { get; set; }

    [JsonProperty("workers")] public double? Workers { get; set; }

    [JsonProperty("value")] public int? Value { get; set; }

    [JsonProperty("cross")] public bool? Cross { get; set; }

    [JsonProperty("gameResult")] public string GameResult { get; set; }

    [JsonProperty("classicElo")] public int? ClassicElo { get; set; }

    [JsonProperty("overallElo")] public int? OverallElo { get; set; }

    [JsonProperty("eloChange")] public int? EloChange { get; set; }

    [JsonProperty("fighters")] public string Fighters { get; set; }

    [JsonProperty("eco")] public bool? Eco { get; set; }

    [JsonProperty("mercenaries")] public string Mercenaries { get; set; }

    [JsonProperty("stayedUntilEnd")] public bool? StayedUntilEnd { get; set; }

    [JsonProperty("chosenSpell")] public string ChosenSpell { get; set; }

    [JsonProperty("chosenSpellLocation")] public string ChosenSpellLocation { get; set; }

    [JsonProperty("partySize")] public int? PartySize { get; set; }

    [JsonProperty("firstWaveFighters")] public string FirstWaveFighters { get; set; }

    [JsonProperty("rolls")] public string Rolls { get; set; }

    [JsonProperty("legionSpecificElo")] public int? LegionSpecificElo { get; set; }

    [JsonProperty("partyMembers")] public List<string> PartyMembers { get; set; }

    [JsonProperty("partyMembersIds")] public List<string> PartyMembersIds { get; set; }

    [JsonProperty("mvpScore")] public int? MvpScore { get; set; }

    [JsonProperty("netWorthPerWave")] public List<int?> NetWorthPerWave { get; set; }

    [JsonProperty("valuePerWave")] public List<int?> ValuePerWave { get; set; }

    [JsonProperty("workersPerWave")] public List<double?> WorkersPerWave { get; set; }

    [JsonProperty("incomePerWave")] public List<int?> IncomePerWave { get; set; }

    [JsonProperty("mercenariesSentPerWave")]
    public List<List<string>> MercenariesSentPerWave { get; set; }

    [JsonProperty("mercenariesReceivedPerWave")]
    public List<List<string>> MercenariesReceivedPerWave { get; set; }

    [JsonProperty("leaksPerWave")] public List<List<string>> LeaksPerWave { get; set; }

    [JsonProperty("buildPerWave")] public List<List<string>> BuildPerWave { get; set; }

    [JsonProperty("leakValue")] public int? LeakValue { get; set; }

    [JsonProperty("leaksCaughtValue")] public int? LeaksCaughtValue { get; set; }

    [JsonProperty("leftAtSeconds")] public double? LeftAtSeconds { get; set; }

    [JsonProperty("kingUpgradesPerWave")] public List<List<string>> KingUpgradesPerWave { get; set; }

    [JsonProperty("opponentKingUpgradesPerWave")]
    public List<List<string>> OpponentKingUpgradesPerWave { get; set; }
}