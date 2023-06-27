# TaF.LegionTD2Api.Api.UnitsApi

All URIs are relative to *https://apiv2.legiontd2.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUnitById**](UnitsApi.md#getunitbyid) | **GET** /units/byId/{id} | Find unit by ID
[**GetUnitByName**](UnitsApi.md#getunitbyname) | **GET** /units/byName/{name} | Find unit by name
[**GetUnitByVersion**](UnitsApi.md#getunitbyversion) | **GET** /units/byVersion/{version} | Find multiple units by version. Usefull for comparing stats between patches.



## GetUnitById

> UnitStats GetUnitById (string id, string version = null)

Find unit by ID

Returns a single unit

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetUnitByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new UnitsApi(Configuration.Default);
            var id = "id_example";  // string | ID of the unit
            var version = "version_example";  // string | Patch version snapshot of this unit. If no value is provided it will default to the most recent patch (optional) 

            try
            {
                // Find unit by ID
                UnitStats result = apiInstance.GetUnitById(id, version);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UnitsApi.GetUnitById: " + e.Message );
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
 **id** | **string**| ID of the unit | 
 **version** | **string**| Patch version snapshot of this unit. If no value is provided it will default to the most recent patch | [optional] 

### Return type

[**UnitStats**](UnitStats.md)

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


## GetUnitByName

> UnitStats GetUnitByName (string name, string version = null)

Find unit by name

Returns a single unit

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetUnitByNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new UnitsApi(Configuration.Default);
            var name = "name_example";  // string | Name of the unit
            var version = "version_example";  // string | Patch version snapshot of this unit. If no value is provided it will default to the most recent patch (optional) 

            try
            {
                // Find unit by name
                UnitStats result = apiInstance.GetUnitByName(name, version);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UnitsApi.GetUnitByName: " + e.Message );
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
 **name** | **string**| Name of the unit | 
 **version** | **string**| Patch version snapshot of this unit. If no value is provided it will default to the most recent patch | [optional] 

### Return type

[**UnitStats**](UnitStats.md)

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


## GetUnitByVersion

> List&lt;UnitStats&gt; GetUnitByVersion (string version, int? limit = null, int? offset = null, bool? enabled = null)

Find multiple units by version. Usefull for comparing stats between patches.

Returns one or more units on a specific version.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetUnitByVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new UnitsApi(Configuration.Default);
            var version = "version_example";  // string | Patch version of the unit
            var limit = 25;  // int? | Maximum number of records to return (max 250 = all units) (optional)  (default to 25)
            var offset = 56;  // int? | Number of records to skip for pagination (optional) 
            var enabled = true;  // bool? | If not set it will return both enabled and disabled units. If set to true only returns enabled units. If set to false, this will return only disabled units. (Note that some units that are used in the game like pack_rat_nest_unit_id are marked as disabled) (optional) 

            try
            {
                // Find multiple units by version. Usefull for comparing stats between patches.
                List<UnitStats> result = apiInstance.GetUnitByVersion(version, limit, offset, enabled);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UnitsApi.GetUnitByVersion: " + e.Message );
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
 **version** | **string**| Patch version of the unit | 
 **limit** | **int?**| Maximum number of records to return (max 250 &#x3D; all units) | [optional] [default to 25]
 **offset** | **int?**| Number of records to skip for pagination | [optional] 
 **enabled** | **bool?**| If not set it will return both enabled and disabled units. If set to true only returns enabled units. If set to false, this will return only disabled units. (Note that some units that are used in the game like pack_rat_nest_unit_id are marked as disabled) | [optional] 

### Return type

[**List&lt;UnitStats&gt;**](UnitStats.md)

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

