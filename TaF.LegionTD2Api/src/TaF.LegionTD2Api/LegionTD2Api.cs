using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaF.LegionTD2Api.ApiModel;
using TaF.LegionTD2Api.Helpers;
using TaF.LegionTD2Api.InternalHttpClient;
using TaF.LegionTD2Api.InternalHttpClient.RateLimiter;
using TaF.LegionTD2Api.Model;

namespace TaF.LegionTD2Api;

/// <summary>
///     Class for interacting with the LegionTD2 API.
/// </summary>
public class LegionTD2Api : ILegionTD2Api
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="LegionTD2Api" /> class.
    /// </summary>
    /// <param name="apiKey">The API key to use for requests.</param>
    public LegionTD2Api(string apiKey)
    {
        Client = new InternalClient(apiKey);
        var rateLimites = new RateLimiterSettings();
        rateLimites.AddRateLimit(250, TimeSpan.FromSeconds(155));
        Client.SetRateLimiter(rateLimites);
    }

    private InternalClient Client { get; }

    /// <summary>
    ///     Gets a player by their ID.
    /// </summary>
    /// <param name="id">The ID of the player.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Player" /> as result.</returns>
    public async Task<Player> GetPlayerByIdAsync(string id)
    {
        return await Client.GetAsync<Player>($"/players/byId/{id}");
    }

    /// <summary>
    ///     Gets a player by their name.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Player" /> as result.</returns>
    public async Task<Player> GetPlayerByNameAsync(string name)
    {
        return await Client.GetAsync<Player>($"/players/byName/{name}");
    }

    /// <summary>
    ///     Get a lists of a players best friends by their ID.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="limit">The maximum number of matches to return.</param>
    /// <param name="offset">The number of matches to skip before starting to return.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Player" /> as result.</returns>
    public async Task<List<Player>> GetBestFriendsByIdAsync(string id, int limit = 10, int offset = 0)
    {
        return await Client.GetAsync<List<Player>>($"/players/bestFriends/{id}?limit={limit}&offset={offset}");
    }

    /// <summary>
    ///     Gets the match history of a player by their ID.
    /// </summary>
    /// <param name="id">The ID of the player.</param>
    /// <param name="limit">The maximum number of matches to return.</param>
    /// <param name="offset">The number of matches to skip before starting to return.</param>
    /// <param name="countresults">Whether to count the results or not.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a list of <see cref="Match" /> as result.</returns>
    public async Task<List<Match>> GetMatchHistoryByPlayerId(string id, int limit = 10, int offset = 0, bool countresults = false)
    {
        return await Client.GetAsync<List<Match>>($"/players/matchHistory/{id}?limit={limit}&offset={offset}");
    }

    /// <summary>
    ///     Gets the stats of a player by their ID.
    /// </summary>
    /// <param name="id">The ID of the player.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="PlayersData" /> as result.</returns>
    public async Task<PlayersData> GetPlayerStatsById(string id)
    {
        return await Client.GetAsync<PlayersData>($"/players/stats/{id}");
    }

    public async Task<List<PlayersData>> GetPlayerStatsByStatistics(int limit = 100, int offset = 0, PlayerSorting playerSorting = PlayerSorting.OverallElo, SortDirection sortDirection = SortDirection.Descending)
    {
        return await Client.GetAsync<List<PlayersData>>($"/players/stats?limit={limit}&offset={offset}&sortBy={playerSorting.GetEnumDescription()}&sortDirection={(int)sortDirection}");
    }

    /// <summary>
    ///     Gets a unit by their ID.
    /// </summary>
    /// <param name="id">The ID of the unit.</param>
    /// <param name="patch">The patch version.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="UnitStats" /> as result.</returns>
    public async Task<UnitStats> GetUnitByIdAsync(string id, string patch = "")
    {
        var patchString = string.IsNullOrWhiteSpace(patch) ? patch : $"?version={patch}";
        return await Client.GetAsync<UnitStats>($"/units/byId/{id}" + patchString);
    }

    /// <summary>
    ///     Gets a unit by their ID for the current patch.
    /// </summary>
    /// <param name="id">The ID of the unit.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="UnitStats" /> as result.</returns>
    public async Task<UnitStats> GetUnitByIdCurrentPatchAsync(string id)
    {
        return await GetUnitByIdAsync(id, string.Empty);
    }

    /// <summary>
    ///     Gets a unit by their name.
    /// </summary>
    /// <param name="name">The name of the unit.</param>
    /// <param name="patch">The patch version.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="UnitStats" /> as result.</returns>
    public async Task<UnitStats> GetUnitByNameAsync(string name, string patch = "")
    {
        var patchString = string.IsNullOrWhiteSpace(patch) ? patch : $"?version={patch}";
        return await Client.GetAsync<UnitStats>($"/units/byName/{name}" + patchString);
    }

    /// <summary>
    ///     Gets a unit by their name for the current patch.
    /// </summary>
    /// <param name="unitName">The name of the unit.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="UnitStats" /> as result.</returns>
    public async Task<UnitStats> GetUnitByNameCurrentPatchAsync(string unitName)
    {
        return await GetUnitByNameAsync(unitName, string.Empty);
    }

    /// <summary>
    ///     Gets games by filters.
    /// </summary>
    /// <param name="queueType">The type of the queue.</param>
    /// <param name="dateBefore">The date before which the games were played.</param>
    /// <param name="dateAfter">The date after which the games were played.</param>
    /// <param name="patch">The patch version.</param>
    /// <param name="limit">The maximum number of games to return.</param>
    /// <param name="offset">The number of games to skip before starting to return.</param>
    /// <param name="gameSortBy">The parameter by which the games should be sorted.</param>
    /// <param name="sortDirection">The direction in which the games should be sorted.</param>
    /// <param name="includeDetails">Whether to include details or not.</param>
    /// <param name="countResults">Whether to count the results or not.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a list of <see cref="Match" /> as result.</returns>
    public async Task<List<Match>> GetGamesByFiltersAsync(QueueType queueType, DateTime dateBefore, DateTime dateAfter, string patch = "", int limit = 50, int offset = 50, GameSortBy gameSortBy = GameSortBy.Date, SortDirection sortDirection = SortDirection.Ascending, bool includeDetails = false, bool countResults = false)
    {
        var query = new QueryBuilder().Add("queueType", queueType.ToString()).Add("dateBefore", dateBefore.ToQueryDateString()).Add("dateAfter", dateAfter.ToQueryDateString()).Add("patch", patch);

        return await Client.GetAsync<List<Match>>("/games" + query.Build());
    }

    /// <summary>
    ///     Gets a game by its ID.
    /// </summary>
    /// <param name="id">The ID of the game.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Match" /> as result.</returns>
    public async Task<Match> GetGamesById(string id)
    {
        return await Client.GetAsync<Match>($"/games/byId/{id}");
    }

    /// <summary>
    ///     Gets a legion by its ID.
    /// </summary>
    /// <param name="id">The ID of the legion.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Legion" /> as result.</returns>
    public async Task<Legion> GetLegionById(string id)
    {
        return await Client.GetAsync<Legion>($"/info/legions/byId/{id}");
    }

    /// <summary>
    ///     Gets a list of legions.
    /// </summary>
    /// <param name="limit">The maximum number of legions to return.</param>
    /// <param name="offset">The number of legions to skip before starting to return.</param>
    /// <param name="playable">Whether to return only playable legions or not.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a list of <see cref="Legion" /> as result.</returns>
    public async Task<List<Legion>> GetLegions(int limit = 10, int offset = 0, bool playable = true)
    {
        return await Client.GetAsync<List<Legion>>($"/info/legions/{offset}/{limit}?playable={playable.ToString().ToLower()}");
    }

    /// <summary>
    ///     Gets a wave by its ID.
    /// </summary>
    /// <param name="id">The ID of the wave.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Wave" /> as result.</returns>
    public async Task<Wave> GetWaveById(string id)
    {
        return await Client.GetAsync<Wave>($"/info/waves/byId/{id}");
    }

    /// <summary>
    ///     Gets a list of waves.
    /// </summary>
    /// <param name="limit">The maximum number of waves to return.</param>
    /// <param name="offset">The number of waves to skip before starting to return.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a list of <see cref="Wave" /> as result.</returns>
    public async Task<List<Wave>> GetWaves(int limit = 10, int offset = 0)
    {
        return await Client.GetAsync<List<Wave>>($"/info/waves/{offset}/{limit}");
    }

    /// <summary>
    ///     Gets a spell by its ID.
    /// </summary>
    /// <param name="id">The ID of the spell.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a <see cref="Spell" /> as result.</returns>
    public async Task<Spell> GetSpellById(string id)
    {
        return await Client.GetAsync<Spell>($"/info/spells/byId/{id}");
    }

    /// <summary>
    ///     Gets a list of spells.
    /// </summary>
    /// <param name="limit">The maximum number of spells to return.</param>
    /// <param name="offset">The number of spells to skip before starting to return.</param>
    /// <param name="enabled">Whether to return only enabled spells or not.</param>
    /// <returns>A <see cref="Task" /> representing the asynchronous operation, with a list of <see cref="Spell" /> as result.</returns>
    public async Task<List<Spell>> GetSpells(int limit = 10, int offset = 0, bool enabled = true)
    {
        return await Client.GetAsync<List<Spell>>($"/info/spells/{offset}/{limit}?enabled={enabled.ToString().ToLower()}");
    }
    
    /// <summary>
    /// Gets an ability by its ID.
    /// </summary>
    /// <param name="id">The ID of the ability.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="Ability"/> as result.</returns>
    public async Task<Ability> GetAbilityById(string id)
    {
        return await Client.GetAsync<Ability>($"/info/abilities/byId/{id}");
    }

    /// <summary>
    /// Gets a list of abilities.
    /// </summary>
    /// <param name="limit">The maximum number of abilities to return.</param>
    /// <param name="offset">The number of abilities to skip before starting to return.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a list of <see cref="Ability"/> as result.</returns>
    public async Task<List<Ability>> GetAbilities(int limit = 10, int offset = 0)
    {
        return await Client.GetAsync<List<Ability>>($"/info/abilities/{offset}/{limit}");
    }

    /// <summary>
    /// Gets a research by its ID.
    /// </summary>
    /// <param name="id">The ID of the research.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="Research"/> as result.</returns>
    public async Task<Research> GetResearchById(string id)
    {
        return await Client.GetAsync<Research>($"/info/research/byId/{id}");
    }

    
    /// <summary>
    /// Gets a description by its ID.
    /// </summary>
    /// <param name="id">The ID of the description.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="Description"/> as result.</returns>
    public async Task<Description> GetDescriptionById(string id)
    {
        return await Client.GetAsync<Description>($"/info/descriptions/{id}");
    }

    /// <summary>
    /// Gets a list of research.
    /// </summary>
    /// <param name="limit">The maximum number of research to return.</param>
    /// <param name="offset">The number of research to skip before starting to return.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a list of <see cref="Research"/> as result.</returns>
    public async Task<List<Research>> GetResearch(int limit = 10, int offset = 0)
    {
        return await Client.GetAsync<List<Research>>($"/info/research/{offset}/{limit}");
    }
}