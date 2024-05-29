using NUnit.Framework;
using TaF.LegionTD2Api;
using System.Threading.Tasks;
using TaF.LegionTD2Api.Model;

namespace Test
{
    public class LegionTD2ApiTests
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
        public async Task TestGetUnitByIdAsync()
        {
            var unit = await _api.GetUnitByIdAsync("66426252a31b711374f81b10");
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
            var unit = await _api.GetUnitByIdCurrentPatchAsync("66426252a31b711374f81e02");
            Assert.IsNotNull(unit);
        }

        [Test]
        public async Task TestGetUnitByNameCurrentPatchAsync()
        {
            var unit = await _api.GetUnitByNameCurrentPatchAsync("grarl");
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
            var legion = await _api.GetLegionById("element_legion_id");
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
            var wave = await _api.GetWaveById("level16_wave_id");
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
    }
}