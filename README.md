# LegionTD2_API - the C# library for the LTD2ApiV2

This is the C# library using the official Legion TD 2 public API. The API endpoint is https://apiv2.legiontd2.com/ <br />

You can generate your key at <a href='https://developer.legiontd2.com/'>developer.legiontd2.com</a>

For icons, emotes or splash art images you can use our CDN: <a href='https://cdn.legiontd2.com/icons/Yozora.png'>cdn.legiontd2.com</a><br />

The current limits are 15 requests per second / 10k burst requests and a maximum of 10k requests per day. The library naturally implements this limit, but allows you to overwrite this in the constructor for `LegionTD2Api`.

If you need a higher limit, reach out to the LegionTD2 team through discord or the support portal. <br /> <br /> If you have any other questions, feel free to ask in the &#35;api channel on the <a href='https://discord.gg/4K4xwCz2DN'>Legion TD 2 Contributors Discord</a>

## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID (optional) 
            var name = "name_example";  // string | Name (optional) 
            var version = "version_example";  // string | Version (optional) 
            var offset = "offset_example";  // string | Offset (optional) 
            var limit = "limit_example";  // string | Limit (optional) 

            try
            {
                apiInstance.PreflightCheck(id, name, version, offset, limit);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://apiv2.legiontd2.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**PreflightCheck**](docs/DefaultApi.md#preflightcheck) | **OPTIONS** /players/byId/{id} | 
*DefaultApi* | [**PreflightCheck_0**](docs/DefaultApi.md#preflightcheck_0) | **OPTIONS** /players/byName/{name} | 
*DefaultApi* | [**PreflightCheck_1**](docs/DefaultApi.md#preflightcheck_1) | **OPTIONS** /players/bestFriends/{id} | 
*DefaultApi* | [**PreflightCheck_10**](docs/DefaultApi.md#preflightcheck_10) | **OPTIONS** /info/legions/{offset}/{limit} | 
*DefaultApi* | [**PreflightCheck_11**](docs/DefaultApi.md#preflightcheck_11) | **OPTIONS** /info/waves/byId/{id} | 
*DefaultApi* | [**PreflightCheck_12**](docs/DefaultApi.md#preflightcheck_12) | **OPTIONS** /info/waves/{offset}/{limit} | 
*DefaultApi* | [**PreflightCheck_13**](docs/DefaultApi.md#preflightcheck_13) | **OPTIONS** /info/spells/byId/{id} | 
*DefaultApi* | [**PreflightCheck_14**](docs/DefaultApi.md#preflightcheck_14) | **OPTIONS** /info/spells/{offset}/{limit} | 
*DefaultApi* | [**PreflightCheck_15**](docs/DefaultApi.md#preflightcheck_15) | **OPTIONS** /info/abilities/byId/{id} | 
*DefaultApi* | [**PreflightCheck_16**](docs/DefaultApi.md#preflightcheck_16) | **OPTIONS** /info/abilities/{offset}/{limit} | 
*DefaultApi* | [**PreflightCheck_17**](docs/DefaultApi.md#preflightcheck_17) | **OPTIONS** /info/research/byId/{id} | 
*DefaultApi* | [**PreflightCheck_18**](docs/DefaultApi.md#preflightcheck_18) | **OPTIONS** /info/research/{offset}/{limit} | 
*DefaultApi* | [**PreflightCheck_19**](docs/DefaultApi.md#preflightcheck_19) | **OPTIONS** /info/descriptions/{id} | 
*DefaultApi* | [**PreflightCheck_2**](docs/DefaultApi.md#preflightcheck_2) | **OPTIONS** /players/matchHistory/{id} | 
*DefaultApi* | [**PreflightCheck_3**](docs/DefaultApi.md#preflightcheck_3) | **OPTIONS** /players/stats/{id} | 
*DefaultApi* | [**PreflightCheck_4**](docs/DefaultApi.md#preflightcheck_4) | **OPTIONS** /players/stats | 
*DefaultApi* | [**PreflightCheck_5**](docs/DefaultApi.md#preflightcheck_5) | **OPTIONS** /units/byId/{id} | 
*DefaultApi* | [**PreflightCheck_6**](docs/DefaultApi.md#preflightcheck_6) | **OPTIONS** /units/byName/{name} | 
*DefaultApi* | [**PreflightCheck_7**](docs/DefaultApi.md#preflightcheck_7) | **OPTIONS** /games | 
*DefaultApi* | [**PreflightCheck_8**](docs/DefaultApi.md#preflightcheck_8) | **OPTIONS** /info/legions/byId/{id} | 
*DefaultApi* | [**PreflightCheck_9**](docs/DefaultApi.md#preflightcheck_9) | **OPTIONS** /games/byId/{id} | 
*DefaultApi* | [**UnitsByVersionVersionOptions**](docs/DefaultApi.md#unitsbyversionversionoptions) | **OPTIONS** /units/byVersion/{version} | 
*GamesApi* | [**GetMatchById**](docs/GamesApi.md#getmatchbyid) | **GET** /games/byId/{id} | Find match by ID
*GamesApi* | [**GetMatchesByFilter**](docs/GamesApi.md#getmatchesbyfilter) | **GET** /games | Find match by different filters
*InfoApi* | [**GetAbilities**](docs/InfoApi.md#getabilities) | **GET** /info/abilities/{offset}/{limit} | Contains information about all abilities
*InfoApi* | [**GetAbilitiesById**](docs/InfoApi.md#getabilitiesbyid) | **GET** /info/abilities/byId/{id} | Find an ability by ID
*InfoApi* | [**GetDescriptionById**](docs/InfoApi.md#getdescriptionbyid) | **GET** /info/descriptions/{id} | Use this to retrieve a specific description by its ID
*InfoApi* | [**GetLegions**](docs/InfoApi.md#getlegions) | **GET** /info/legions/{offset}/{limit} | Contains all playable and unplayable legions.
*InfoApi* | [**GetLegionsById**](docs/InfoApi.md#getlegionsbyid) | **GET** /info/legions/byId/{id} | Find a legion by ID
*InfoApi* | [**GetResearches**](docs/InfoApi.md#getresearches) | **GET** /info/research/{offset}/{limit} | Contains information about all researches (king upgrades, hiring workers, etc.)
*InfoApi* | [**GetResearchesById**](docs/InfoApi.md#getresearchesbyid) | **GET** /info/research/byId/{id} | Find a research (for example king upgrades) by ID
*InfoApi* | [**GetSpells**](docs/InfoApi.md#getspells) | **GET** /info/spells/{offset}/{limit} | Contains all enabled or disabled legion spells.
*InfoApi* | [**GetSpellsById**](docs/InfoApi.md#getspellsbyid) | **GET** /info/spells/byId/{id} | Find a legion spell by ID
*InfoApi* | [**GetWaves**](docs/InfoApi.md#getwaves) | **GET** /info/waves/{offset}/{limit} | Contains information about all waves
*InfoApi* | [**GetWavesById**](docs/InfoApi.md#getwavesbyid) | **GET** /info/waves/byId/{id} | Find a wave by ID
*PlayerApi* | [**GetPlayerById**](docs/PlayerApi.md#getplayerbyid) | **GET** /players/byId/{id} | Find player by ID
*PlayerApi* | [**GetPlayerByName**](docs/PlayerApi.md#getplayerbyname) | **GET** /players/byName/{name} | Find player by their nickname
*PlayerApi* | [**GetPlayerFriends**](docs/PlayerApi.md#getplayerfriends) | **GET** /players/bestFriends/{id} | Find other players that had common games with this player
*PlayerApi* | [**GetPlayerHistory**](docs/PlayerApi.md#getplayerhistory) | **GET** /players/matchHistory/{id} | Get most recent matches of this player
*PlayerApi* | [**GetPlayerStats**](docs/PlayerApi.md#getplayerstats) | **GET** /players/stats/{id} | Get player statistics (wins, losses, etc.)
*PlayerApi* | [**GetSortedPlayerStats**](docs/PlayerApi.md#getsortedplayerstats) | **GET** /players/stats | Get sorted player statistics (wins, losses, etc.)
*UnitsApi* | [**GetUnitById**](docs/UnitsApi.md#getunitbyid) | **GET** /units/byId/{id} | Find unit by ID
*UnitsApi* | [**GetUnitByName**](docs/UnitsApi.md#getunitbyname) | **GET** /units/byName/{name} | Find unit by name
*UnitsApi* | [**GetUnitByVersion**](docs/UnitsApi.md#getunitbyversion) | **GET** /units/byVersion/{version} | Find multiple units by version. Usefull for comparing stats between patches.


## Documentation for Models

 - [Model.Ability](docs/Ability.md)
 - [Model.Description](docs/Description.md)
 - [Model.Legion](docs/Legion.md)
 - [Model.Match](docs/Match.md)
 - [Model.Player](docs/Player.md)
 - [Model.PlayerFriends](docs/PlayerFriends.md)
 - [Model.PlayerFriendsId](docs/PlayerFriendsId.md)
 - [Model.PlayerMatchdetails](docs/PlayerMatchdetails.md)
 - [Model.QueueType](docs/QueueType.md)
 - [Model.Research](docs/Research.md)
 - [Model.Spell](docs/Spell.md)
 - [Model.Stats](docs/Stats.md)
 - [Model.UnitStats](docs/UnitStats.md)
 - [Model.Wave](docs/Wave.md)
