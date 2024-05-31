using TaF.LegionTD2Api;
using TaF.LegionTD2Api.Model;

namespace DataGatherHelper;

internal class Program
{
    private static LegionTD2Api _api;

    private static async Task Main(string[] args)
    {
        _api = new LegionTD2Api(Environment.GetEnvironmentVariable("LEGION_TD2_API_KEY"));
        var matches = await _api.GetMatchHistoryByPlayerId("1D40BE6103042235");
        var units = new List<string>();
        var playerIds = new List<string>();
        foreach (var match in matches)
        {
            ExtractDataFromPlayerData(match, units);
            foreach (var playersData in match.PlayersData)
            {
                playerIds.Add(playersData.PlayerId);
            }
        }

        matches = new List<Match>();
        foreach (var playerId in playerIds)
        {
            matches.AddRange(await _api.GetMatchHistoryByPlayerId(playerId));
        }
        
        matches = matches.Distinct().ToList();
        foreach (var match in matches)
        {
            ExtractDataFromPlayerData(match, units);
        }
        units = units.Distinct().ToList();
        foreach (var unit in units)
        {
            Console.WriteLine(unit);
        }
    }

    private static void ExtractDataFromPlayerData(Match match, List<string> units)
    {
        foreach (var data in match.PlayersData)
        {
            if (!data.Fighters.Contains(","))
            {
                units.Add(data.Fighters);
            }
            else
            {
                var fighters = data.Fighters.Split(",");
                units.AddRange(fighters);
            }
        }
    }
}