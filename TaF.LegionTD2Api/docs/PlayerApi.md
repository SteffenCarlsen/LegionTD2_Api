# TaF.LegionTD2Api.Api.PlayerApi

All URIs are relative to *https://apiv2.legiontd2.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPlayerById**](PlayerApi.md#getplayerbyid) | **GET** /players/byId/{id} | Find player by ID
[**GetPlayerByName**](PlayerApi.md#getplayerbyname) | **GET** /players/byName/{name} | Find player by their nickname
[**GetPlayerFriends**](PlayerApi.md#getplayerfriends) | **GET** /players/bestFriends/{id} | Find other players that had common games with this player
[**GetPlayerHistory**](PlayerApi.md#getplayerhistory) | **GET** /players/matchHistory/{id} | Get most recent matches of this player
[**GetPlayerStats**](PlayerApi.md#getplayerstats) | **GET** /players/stats/{id} | Get player statistics (wins, losses, etc.)
[**GetSortedPlayerStats**](PlayerApi.md#getsortedplayerstats) | **GET** /players/stats | Get sorted player statistics (wins, losses, etc.)



## GetPlayerById

> List&lt;Player&gt; GetPlayerById (string id)

Find player by ID

Returns a single player profile

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetPlayerByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerApi(Configuration.Default);
            var id = "id_example";  // string | Account ID of the player

            try
            {
                // Find player by ID
                List<Player> result = apiInstance.GetPlayerById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Account ID of the player | 

### Return type

[**List&lt;Player&gt;**](Player.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlayerByName

> List&lt;Player&gt; GetPlayerByName (string name)

Find player by their nickname

Returns a single player profile

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetPlayerByNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerApi(Configuration.Default);
            var name = "name_example";  // string | Display name of the player

            try
            {
                // Find player by their nickname
                List<Player> result = apiInstance.GetPlayerByName(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Display name of the player | 

### Return type

[**List&lt;Player&gt;**](Player.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlayerFriends

> PlayerFriends GetPlayerFriends (string id, int? limit = null, int? offset = null)

Find other players that had common games with this player

Returns one or more player profiles and how many games they played together.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetPlayerFriendsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerApi(Configuration.Default);
            var id = "id_example";  // string | ID of the player
            var limit = 10;  // int? | Maximum number of records to return (optional)  (default to 10)
            var offset = 0;  // int? | Number of records to skip for pagination (optional)  (default to 0)

            try
            {
                // Find other players that had common games with this player
                PlayerFriends result = apiInstance.GetPlayerFriends(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerFriends: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the player | 
 **limit** | **int?**| Maximum number of records to return | [optional] [default to 10]
 **offset** | **int?**| Number of records to skip for pagination | [optional] [default to 0]

### Return type

[**PlayerFriends**](PlayerFriends.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlayerHistory

> List&lt;Match&gt; GetPlayerHistory (string id, int? limit = null, int? offset = null, bool? countResults = null)

Get most recent matches of this player

Returns one or more matches of this player

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetPlayerHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerApi(Configuration.Default);
            var id = "id_example";  // string | Account ID of the player
            var limit = 10;  // int? | Maximum number of records to return (optional)  (default to 10)
            var offset = 0;  // int? | Number of records to skip for pagination (optional)  (default to 0)
            var countResults = false;  // bool? | Include the amount of entries for this query (optional)  (default to false)

            try
            {
                // Get most recent matches of this player
                List<Match> result = apiInstance.GetPlayerHistory(id, limit, offset, countResults);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Account ID of the player | 
 **limit** | **int?**| Maximum number of records to return | [optional] [default to 10]
 **offset** | **int?**| Number of records to skip for pagination | [optional] [default to 0]
 **countResults** | **bool?**| Include the amount of entries for this query | [optional] [default to false]

### Return type

[**List&lt;Match&gt;**](Match.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlayerStats

> Stats GetPlayerStats (string id)

Get player statistics (wins, losses, etc.)

Returns stats of the specified player

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetPlayerStatsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerApi(Configuration.Default);
            var id = "id_example";  // string | ID of the player

            try
            {
                // Get player statistics (wins, losses, etc.)
                Stats result = apiInstance.GetPlayerStats(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerStats: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the player | 

### Return type

[**Stats**](Stats.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSortedPlayerStats

> Stats GetSortedPlayerStats (int? limit = null, int? offset = null, string sortBy = null, decimal? sortDirection = null)

Get sorted player statistics (wins, losses, etc.)

Returns one or more player profiles and their stats

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetSortedPlayerStatsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlayerApi(Configuration.Default);
            var limit = 100;  // int? | Maximum number of records to return (optional)  (default to 100)
            var offset = 56;  // int? | Number of records to skip for pagination (optional) 
            var sortBy = "overallElo";  // string | Sort stats by this value (has to be a valid stats key) (optional)  (default to overallElo)
            var sortDirection = 1D;  // decimal? | Specify sort direction. 1 is ASC, -1 is DESC (optional)  (default to -1M)

            try
            {
                // Get sorted player statistics (wins, losses, etc.)
                Stats result = apiInstance.GetSortedPlayerStats(limit, offset, sortBy, sortDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayerApi.GetSortedPlayerStats: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Maximum number of records to return | [optional] [default to 100]
 **offset** | **int?**| Number of records to skip for pagination | [optional] 
 **sortBy** | **string**| Sort stats by this value (has to be a valid stats key) | [optional] [default to overallElo]
 **sortDirection** | **decimal?**| Specify sort direction. 1 is ASC, -1 is DESC | [optional] [default to -1M]

### Return type

[**Stats**](Stats.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

