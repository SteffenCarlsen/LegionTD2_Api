using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using TaF.LegionTD2Api.ApiModel;
using TaF.LegionTD2Api.Model;

namespace TaF.LegionTD2Api;

public interface ILegionTD2Api
{
 Task<Player> GetPlayerByIdAsync(string id);
 Task<Player> GetPlayerByNameAsync(string name);
 Task<List<Player>> GetBestFriendsByIdAsync(string id, int limit = 10, int offset = 0);
 Task<List<Match>> GetMatchHistoryByPlayerId(string id, int limit = 10, int offset = 0, bool countresults = false);
 Task<PlayersData> GetPlayerStatsById(string id);
 Task<List<PlayersData>> GetPlayerStatsBySorting(int limit = 100, int offset = 0, PlayerSorting playerSorting = PlayerSorting.OverallElo, SortDirection sortDirection = SortDirection.Ascending);
 Task<UnitStats> GetUnitByIdAsync(string id, string patch = "");
 Task<UnitStats> GetUnitByIdCurrentPatchAsync(string id);
 Task<UnitStats> GetUnitByNameAsync(string name, string patch = "");
 Task<UnitStats> GetUnitByNameCurrentPatchAsync(string unitName);
 Task<List<Match>> GetGamesByFiltersAsync(QueueType queueType, DateTime dateBefore, DateTime dateAfter, string patch = "", int limit = 50, int offset = 50, GameSortBy gameSortBy = GameSortBy.Date, SortDirection sortDirection = SortDirection.Ascending, bool includeDetails = false, bool countResults = false);
 Task<Match> GetGamesById(string id);
 Task<Legion> GetLegionById(string id);
 Task<List<Legion>> GetLegions(int limit = 10, int offset = 0, bool playable = true);
 Task<Wave> GetWaveById(string id);
 Task<List<Wave>> GetWaves(int limit = 10, int offset = 0);
 Task<Spell> GetSpellById(string id);
 Task<List<Spell>> GetSpells(int limit = 10, int offset = 0, bool enabled = true);
}