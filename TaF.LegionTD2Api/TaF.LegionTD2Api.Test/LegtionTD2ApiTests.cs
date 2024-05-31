using TaF.LegionTD2Api.ApiModel;
using TaF.LegionTD2Api.Model;

namespace TaF.LegionTD2Api.Test;

public class LegionTd2ApiTests
{
    private LegionTD2Api _api;

    [SetUp]
    public void Setup()
    {
        _api = new LegionTD2Api(Environment.GetEnvironmentVariable("LEGION_TD2_API_KEY"));
    }

    [Test]
    public async Task TestGetPlayerByIdAsync()
    {
        var player = await _api.GetPlayerByIdAsync("1D40BE6103042235");
        Assert.IsNotNull(player);
    }

    [Test]
    public async Task TestGetPlayerByNameAsync()
    {
        var player = await _api.GetPlayerByNameAsync("TaF");
        Assert.IsNotNull(player);
    }
    
    [Test]
    public async Task GetPlayerStatisticsBySorting()
    {
        var players = await _api.GetPlayerStatsByStatistics(100, 0, PlayerSorting.OverallElo, SortDirection.Descending);
        Assert.IsNotNull(players);
        Assert.IsNotEmpty(players);
    }

    [Test]
    public async Task TestGetUnitByIdAsync()
    {
        var unit = await _api.GetUnitByIdAsync("grarl_unit_id", "11.04.hf2");
        Assert.IsNotNull(unit);
    }

    [Test]
    public async Task TestGetUnitByNameAsync()
    {
        var unit = await _api.GetUnitByNameAsync("grarl", "11.04.hf2");
        Assert.IsNotNull(unit);
    }

    [Test]
    public async Task TestGetUnitByIdCurrentPatchAsync()
    {
        var unit = await _api.GetUnitByIdCurrentPatchAsync("grarl_unit_id");
        Assert.IsNotNull(unit);
    }

    [Test]
    public async Task TestGetUnitByNameCurrentPatchAsync()
    {
        var unit = await _api.GetUnitByNameCurrentPatchAsync("hydra");
        Assert.IsNotNull(unit);
    }

    [Test]
    public async Task TestGetGamesByFiltersAsync()
    {
        // You need to replace the parameters with appropriate values
        var matches = await _api.GetGamesByFiltersAsync(QueueType.Classic, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-20));
        Assert.IsNotNull(matches);
        Assert.IsNotEmpty(matches);
    }

    [Test]
    public async Task TestGetGamesByFiltersAsyncById()
    {
        var match = await _api.GetGamesById("363ed925d7b7826e34370f40bb107ff41cb775abe1a03a6e4b29ddcaba69ede2");
        Assert.IsNotNull(match);
    }

    [Test]
    public async Task TestGetLegionById()
    {
        var legion = await _api.GetLegionById(LegionTDAPINameHelper.LegionNames.Divine);
        Assert.IsNotNull(legion);
    }

    [Test]
    public async Task TestGetLegions()
    {
        var legions = await _api.GetLegions();
        Assert.IsNotNull(legions);
    }

    [Test]
    public async Task TestGetWaveById()
    {
        var wave = await _api.GetWaveById(LegionTDAPINameHelper.WaveNames.Wave1);
        Assert.IsNotNull(wave);
    }

    [Test]
    public async Task TestGetWaveByIdList()
    {
        var waves = await _api.GetWaves();
        Assert.IsNotNull(waves);
        Assert.IsNotEmpty(waves);
    }

    [Test]
    public async Task TestGetSpellById()
    {
        var spell = await _api.GetSpellById("dark_ritual_powerup_id");
        Assert.IsNotNull(spell);
    }

    [Test]
    public async Task TestGetSpells()
    {
        var spells = await _api.GetSpells();
        Assert.IsNotNull(spells);
        Assert.IsNotEmpty(spells);
    }

    [Test]
    public async Task GetPlayerMatchHistory()
    {
        var matches = await _api.GetMatchHistoryByPlayerId("1D40BE6103042235");
        Assert.IsNotNull(matches);
        Assert.IsNotEmpty(matches);
    }
    
    [Test]
    public async Task GetAbilityById()
    {
        var ability = await _api.GetAbilityById("pulverize_melee_ability_id");
        Assert.IsNotNull(ability);
    }
    
    [Test]
    public async Task GetAbilities()
    {
        var abilities = await _api.GetAbilities();
        Assert.IsNotNull(abilities);
        Assert.IsNotEmpty(abilities);
    }
    [Test]
    public async Task GetDescriptionById()
    {
        var ability = await _api.GetDescriptionById("pulverize_description");
        Assert.IsNotNull(ability);
    } 
    [Test]
    public async Task GetResearchById()
    {
        var ability = await _api.GetResearchById("king_regen_research_id");
        Assert.IsNotNull(ability);
    }
    
    [Test]
    public async Task GetResearch()
    {
        var abilities = await _api.GetResearch();
        Assert.IsNotNull(abilities);
        Assert.IsNotEmpty(abilities);
    }

    [Test]
    public async Task GetLegionNames()
    {
        var legionNames = new List<Legion>();
        for (int i = 0; legionNames.Count * i + 1 < i*10 ; i++)
        {
            var legions = await _api.GetLegions(10, i * 10);
            legions.AddRange(legions);
        }

        string l = string.Empty;
        foreach (var legion in legionNames)
        {
            l += ($"{legion.Name}," + Environment.NewLine);
        }

        Console.ReadKey();
    }
}