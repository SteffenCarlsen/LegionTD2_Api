# TaF.LegionTD2Api.Api.GamesApi

All URIs are relative to *https://apiv2.legiontd2.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMatchById**](GamesApi.md#getmatchbyid) | **GET** /games/byId/{id} | Find match by ID
[**GetMatchesByFilter**](GamesApi.md#getmatchesbyfilter) | **GET** /games | Find match by different filters



## GetMatchById

> Match GetMatchById (string id, bool? includeDetails = null)

Find match by ID

Returns a single match

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetMatchByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GamesApi(Configuration.Default);
            var id = "id_example";  // string | ID of the match
            var includeDetails = false;  // bool? | Include player specific match details (optional)  (default to false)

            try
            {
                // Find match by ID
                Match result = apiInstance.GetMatchById(id, includeDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GamesApi.GetMatchById: " + e.Message );
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
 **id** | **string**| ID of the match | 
 **includeDetails** | **bool?**| Include player specific match details | [optional] [default to false]

### Return type

[**Match**](Match.md)

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


## GetMatchesByFilter

> List&lt;Match&gt; GetMatchesByFilter (string version = null, int? limit = null, int? offset = null, string sortBy = null, decimal? sortDirection = null, string dateBefore = null, string dateAfter = null, bool? includeDetails = null, bool? countResults = null, List<QueueType> queueType = null)

Find match by different filters

Returns one or more matches based on patch version

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetMatchesByFilterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GamesApi(Configuration.Default);
            var version = "version_example";  // string | Patch version of the match (optional) 
            var limit = 50;  // int? | Maximum number of records to return (optional)  (default to 50)
            var offset = 56;  // int? | Number of records to skip for pagination (optional) 
            var sortBy = "date";  // string | Sort games before fetching and limiting by this value (optional)  (default to date)
            var sortDirection = 1D;  // decimal? | Specify sort direction. 1 is ASC, -1 is DESC (optional)  (default to 1M)
            var dateBefore = 2021-11-07 13:37:00;  // string | Return games that started before this date/time in UTC (YYYY-MM-DD HH:MM:SS) (optional) 
            var dateAfter = 2021-11-06 13:37:00;  // string | Return games that started after this date/time in UTC (YYYY-MM-DD HH:MM:SS) (optional) 
            var includeDetails = false;  // bool? | Include player specific match details (optional)  (default to false)
            var countResults = false;  // bool? | Include the amount of entries for this query (optional)  (default to false)
            var queueType = new List<QueueType>(); // List<QueueType> | Specify queue type of the match (optional) 

            try
            {
                // Find match by different filters
                List<Match> result = apiInstance.GetMatchesByFilter(version, limit, offset, sortBy, sortDirection, dateBefore, dateAfter, includeDetails, countResults, queueType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GamesApi.GetMatchesByFilter: " + e.Message );
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
 **version** | **string**| Patch version of the match | [optional] 
 **limit** | **int?**| Maximum number of records to return | [optional] [default to 50]
 **offset** | **int?**| Number of records to skip for pagination | [optional] 
 **sortBy** | **string**| Sort games before fetching and limiting by this value | [optional] [default to date]
 **sortDirection** | **decimal?**| Specify sort direction. 1 is ASC, -1 is DESC | [optional] [default to 1M]
 **dateBefore** | **string**| Return games that started before this date/time in UTC (YYYY-MM-DD HH:MM:SS) | [optional] 
 **dateAfter** | **string**| Return games that started after this date/time in UTC (YYYY-MM-DD HH:MM:SS) | [optional] 
 **includeDetails** | **bool?**| Include player specific match details | [optional] [default to false]
 **countResults** | **bool?**| Include the amount of entries for this query | [optional] [default to false]
 **queueType** | [**List&lt;QueueType&gt;**](QueueType.md)| Specify queue type of the match | [optional] 

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

