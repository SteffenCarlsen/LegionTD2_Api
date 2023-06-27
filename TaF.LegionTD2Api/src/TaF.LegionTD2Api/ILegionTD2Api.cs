using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using TaF.LegionTD2Api.ApiModel;
using TaF.LegionTD2Api.Model;

namespace TaF.LegionTD2Api;

public interface ILegionTD2Api
{
    /*
     * Players
     */
    // /players/byId/{id}
    public Task<Player> GetPlayerByIdAsync(int id);
    // /players/byName/{name}
    public Task<Player> GetPlayerByNameAsync(string name);
    // /players/bestFriends/{id}
    public Task<List<Player>> GetBestFriendsByIdAsync(int id, int limit = 10, int offset = 0);
    // /players/matchHistory/{id}
    public Task<List<Match>> GetMatchHistoryByPlayerId(int id, int limit = 10, int offset = 0, bool countresults = false);
    // /players/stats/{id}
    public Task<PlayersData> GetPlayerStatsById(int id);
    // /players/stats
    public Task<List<PlayersData>> GetPlayerStatsBySorting(int limit = 100, int offset = 0, PlayerSorting playerSorting = PlayerSorting.OverallElo, SortDirection sortDirection = SortDirection.Ascending);
    
    /*
     * Units
     */
    public Task<UnitStats> GetUnitByIdAsync(int id, string patch = "");
    
    public Task<UnitStats> GetUnitByNameAsync(string name, string patch = "");

    public Task<UnitStats> GetUnitByIdCurrentPatchAsync(int id);
    
    public Task<List<UnitStats>> GetUnitByNameAsync(string patch = "");
    public Task<List<UnitStats>> GetUnitByNameCurrentPatchAsync();

    /*
     * Games
     */
    public Task<List<Match>> GetGamesByFiltersAsync( QueueType queueType, DateTime dateBefore, DateTime dateAfter, string patch = "", int limit = 50, int offset = 50, GameSortBy gameSortBy = GameSortBy.Date, SortDirection sortDirection = SortDirection.Ascending, bool includeDetails = false, bool countResults = false);
    public Task<Match> GetGamesByFiltersAsync(Guid id);

    /*
     * Info
     */
    public Task<Legion> GetLegionById(string id);
    public Task<Legion> GetLegions(int limit = 10, int offset = 0, bool playable = true);
    public Task<Wave> GetWaveById(string id);
    public Task<List<Wave>> GetWaveById(int limit = 10, int offset = 0);
    public Task<Spell> GetSpellById(string id);
    public Task<List<Spell>> GetSpellById(int limit = 10, int offset = 0, bool enabled = true);
}