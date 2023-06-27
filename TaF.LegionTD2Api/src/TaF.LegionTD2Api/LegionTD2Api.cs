using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaF.LegionTD2Api.ApiModel;
using TaF.LegionTD2Api.Helpers;
using TaF.LegionTD2Api.InternalHttpClient;
using TaF.LegionTD2Api.InternalHttpClient.RateLimiter;
using TaF.LegionTD2Api.Model;

namespace TaF.LegionTD2Api;

public class LegionTD2Api : ILegionTD2Api
{
    public InternalClient _client { get; }
    
    public LegionTD2Api(string apiKey)
    {
        _client = new InternalClient(apiKey);
        var rateLimites = new RateLimiterSettings();
        rateLimites.AddRateLimit(250, TimeSpan.FromSeconds(155));
        _client.SetRateLimiter(rateLimites);
    }
    
    public async Task<Player> GetPlayerByIdAsync(int id)
    {
        return await _client.GetAsync<Player>($"/players/byId/{id}");
    }

    public async Task<Player> GetPlayerByNameAsync(string name)
    {
        return await _client.GetAsync<Player>($"/players/byName/{name}");
    }

    public async Task<List<Player>> GetBestFriendsByIdAsync(int id, int limit = 10, int offset = 0)
    {
        return await _client.GetAsync<List<Player>>($"/players/bestFriends/{id}?limit={limit}&offset={offset}");
    }

    public async Task<List<Match>> GetMatchHistoryByPlayerId(int id, int limit = 10, int offset = 0, bool countresults = false)
    {
        return await _client.GetAsync<List<Match>>($"/players/matchHistory/{id}?limit={limit}&offset={offset}");   
    }

    public async Task<PlayersData> GetPlayerStatsById(int id)
    {
        return await _client.GetAsync<PlayersData>($"/players/stats/{id}");
    }

    public async Task<List<PlayersData>> GetPlayerStatsBySorting(int limit = 100, int offset = 0, PlayerSorting playerSorting = PlayerSorting.OverallElo, SortDirection sortDirection = SortDirection.Ascending)
    {
        return await _client.GetAsync<List<PlayersData>>($"/players/stats?limit={limit}&offset={offset}&{playerSorting.GetEnumDescription()}&sortDirection={sortDirection}");  
    }

    public async Task<UnitStats> GetUnitByIdAsync(int id, string patch = "")
    {
        var patchString = string.IsNullOrWhiteSpace(patch) ? patch : $"?version={patch}";
        return await _client.GetAsync<UnitStats>($"/units/byId/{id}" + patchString);
    }
    
    public async Task<UnitStats> GetUnitByIdCurrentPatchAsync(int id)
    {
        return await GetUnitByIdAsync(id, string.Empty);
    }

    public async Task<UnitStats> GetUnitByNameAsync(string name, string patch = "")
    {
        var patchString = string.IsNullOrWhiteSpace(patch) ? patch : $"?version={patch}";
        return await _client.GetAsync<UnitStats>($"/units/byName/{name}" + patchString);
    }

    public async Task<List<UnitStats>> GetUnitByNameAsync(string patch = "")
    {
        var patchString = string.IsNullOrWhiteSpace(patch) ? patch : $"?version={patch}";
        return await _client.GetAsync<List<UnitStats>>($"/units/byVersion/" + patchString);
    } 
    
    public async Task<List<UnitStats>> GetUnitByNameCurrentPatchAsync()
    {
        return await GetUnitByNameAsync(string.Empty);
    }

    public async Task<List<Match>> GetGamesByFiltersAsync(QueueType queueType, DateTime dateBefore, DateTime dateAfter, string patch = "",
        int limit = 50, int offset = 50, GameSortBy gameSortBy = GameSortBy.Date,
        SortDirection sortDirection = SortDirection.Ascending, bool includeDetails = false, bool countResults = false)
    {
        throw new NotImplementedException();
    }

    public async Task<Match> GetGamesByFiltersAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Legion> GetLegionById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Legion> GetLegions(int limit = 10, int offset = 0, bool playable = true)
    {
        throw new NotImplementedException();
    }

    public async Task<Wave> GetWaveById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Wave>> GetWaveById(int limit = 10, int offset = 0)
    {
        throw new NotImplementedException();
    }

    public async Task<Spell> GetSpellById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Spell>> GetSpellById(int limit = 10, int offset = 0, bool enabled = true)
    {
        throw new NotImplementedException();
    }
}