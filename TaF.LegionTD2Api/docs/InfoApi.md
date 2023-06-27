# TaF.LegionTD2Api.Api.InfoApi

All URIs are relative to *https://apiv2.legiontd2.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAbilities**](InfoApi.md#getabilities) | **GET** /info/abilities/{offset}/{limit} | Contains information about all abilities
[**GetAbilitiesById**](InfoApi.md#getabilitiesbyid) | **GET** /info/abilities/byId/{id} | Find an ability by ID
[**GetDescriptionById**](InfoApi.md#getdescriptionbyid) | **GET** /info/descriptions/{id} | Use this to retrieve a specific description by its ID
[**GetLegions**](InfoApi.md#getlegions) | **GET** /info/legions/{offset}/{limit} | Contains all playable and unplayable legions.
[**GetLegionsById**](InfoApi.md#getlegionsbyid) | **GET** /info/legions/byId/{id} | Find a legion by ID
[**GetResearches**](InfoApi.md#getresearches) | **GET** /info/research/{offset}/{limit} | Contains information about all researches (king upgrades, hiring workers, etc.)
[**GetResearchesById**](InfoApi.md#getresearchesbyid) | **GET** /info/research/byId/{id} | Find a research (for example king upgrades) by ID
[**GetSpells**](InfoApi.md#getspells) | **GET** /info/spells/{offset}/{limit} | Contains all enabled or disabled legion spells.
[**GetSpellsById**](InfoApi.md#getspellsbyid) | **GET** /info/spells/byId/{id} | Find a legion spell by ID
[**GetWaves**](InfoApi.md#getwaves) | **GET** /info/waves/{offset}/{limit} | Contains information about all waves
[**GetWavesById**](InfoApi.md#getwavesbyid) | **GET** /info/waves/byId/{id} | Find a wave by ID



## GetAbilities

> List&lt;Ability&gt; GetAbilities (int limit, int offset)

Contains information about all abilities

Returns one or more abilities

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetAbilitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var limit = 10;  // int | Maximum number of records to return (default to 10)
            var offset = 0;  // int | Number of records to skip for pagination (default to 0)

            try
            {
                // Contains information about all abilities
                List<Ability> result = apiInstance.GetAbilities(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetAbilities: " + e.Message );
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
 **limit** | **int**| Maximum number of records to return | [default to 10]
 **offset** | **int**| Number of records to skip for pagination | [default to 0]

### Return type

[**List&lt;Ability&gt;**](Ability.md)

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


## GetAbilitiesById

> Ability GetAbilitiesById (string id)

Find an ability by ID

Returns a single ability by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetAbilitiesByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var id = "id_example";  // string | ID of the ability

            try
            {
                // Find an ability by ID
                Ability result = apiInstance.GetAbilitiesById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetAbilitiesById: " + e.Message );
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
 **id** | **string**| ID of the ability | 

### Return type

[**Ability**](Ability.md)

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


## GetDescriptionById

> Description GetDescriptionById (string id)

Use this to retrieve a specific description by its ID

Returns one description text

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetDescriptionByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var id = "id_example";  // string | ID of the description

            try
            {
                // Use this to retrieve a specific description by its ID
                Description result = apiInstance.GetDescriptionById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetDescriptionById: " + e.Message );
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
 **id** | **string**| ID of the description | 

### Return type

[**Description**](Description.md)

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


## GetLegions

> List&lt;Legion&gt; GetLegions (int limit, int offset, bool? playable = null)

Contains all playable and unplayable legions.

Returns one or more legions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetLegionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var limit = 10;  // int | Maximum number of records to return (default to 10)
            var offset = 0;  // int | Number of records to skip for pagination (default to 0)
            var playable = true;  // bool? | Only return playable legions. Unplayable legions usually contain NPCs like the king or unfinished legions that are still have unreleased units. (optional)  (default to true)

            try
            {
                // Contains all playable and unplayable legions.
                List<Legion> result = apiInstance.GetLegions(limit, offset, playable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetLegions: " + e.Message );
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
 **limit** | **int**| Maximum number of records to return | [default to 10]
 **offset** | **int**| Number of records to skip for pagination | [default to 0]
 **playable** | **bool?**| Only return playable legions. Unplayable legions usually contain NPCs like the king or unfinished legions that are still have unreleased units. | [optional] [default to true]

### Return type

[**List&lt;Legion&gt;**](Legion.md)

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


## GetLegionsById

> Legion GetLegionsById (string id)

Find a legion by ID

Returns a single legion by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetLegionsByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var id = "id_example";  // string | ID of the legion

            try
            {
                // Find a legion by ID
                Legion result = apiInstance.GetLegionsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetLegionsById: " + e.Message );
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
 **id** | **string**| ID of the legion | 

### Return type

[**Legion**](Legion.md)

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


## GetResearches

> List&lt;Research&gt; GetResearches (int limit, int offset)

Contains information about all researches (king upgrades, hiring workers, etc.)

Returns one or more researches

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetResearchesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var limit = 10;  // int | Maximum number of records to return (default to 10)
            var offset = 0;  // int | Number of records to skip for pagination (default to 0)

            try
            {
                // Contains information about all researches (king upgrades, hiring workers, etc.)
                List<Research> result = apiInstance.GetResearches(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetResearches: " + e.Message );
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
 **limit** | **int**| Maximum number of records to return | [default to 10]
 **offset** | **int**| Number of records to skip for pagination | [default to 0]

### Return type

[**List&lt;Research&gt;**](Research.md)

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


## GetResearchesById

> Research GetResearchesById (string id)

Find a research (for example king upgrades) by ID

Returns a single research by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetResearchesByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var id = "id_example";  // string | ID of the research

            try
            {
                // Find a research (for example king upgrades) by ID
                Research result = apiInstance.GetResearchesById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetResearchesById: " + e.Message );
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
 **id** | **string**| ID of the research | 

### Return type

[**Research**](Research.md)

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


## GetSpells

> List&lt;Spell&gt; GetSpells (int limit, int offset, bool? enabled = null)

Contains all enabled or disabled legion spells.

Returns one or more legion spells

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetSpellsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var limit = 10;  // int | Maximum number of records to return (default to 10)
            var offset = 0;  // int | Number of records to skip for pagination (default to 0)
            var enabled = true;  // bool? | Only return enabled spells. Disabled spells are either experimental or deprecated (optional)  (default to true)

            try
            {
                // Contains all enabled or disabled legion spells.
                List<Spell> result = apiInstance.GetSpells(limit, offset, enabled);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetSpells: " + e.Message );
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
 **limit** | **int**| Maximum number of records to return | [default to 10]
 **offset** | **int**| Number of records to skip for pagination | [default to 0]
 **enabled** | **bool?**| Only return enabled spells. Disabled spells are either experimental or deprecated | [optional] [default to true]

### Return type

[**List&lt;Spell&gt;**](Spell.md)

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


## GetSpellsById

> Spell GetSpellsById (string id)

Find a legion spell by ID

Returns a single legion spell by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetSpellsByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var id = "id_example";  // string | ID of the legion

            try
            {
                // Find a legion spell by ID
                Spell result = apiInstance.GetSpellsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetSpellsById: " + e.Message );
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
 **id** | **string**| ID of the legion | 

### Return type

[**Spell**](Spell.md)

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


## GetWaves

> List&lt;Wave&gt; GetWaves (int limit, int offset)

Contains information about all waves

Returns one or more waves

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetWavesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var limit = 10;  // int | Maximum number of records to return (default to 10)
            var offset = 0;  // int | Number of records to skip for pagination (default to 0)

            try
            {
                // Contains information about all waves
                List<Wave> result = apiInstance.GetWaves(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetWaves: " + e.Message );
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
 **limit** | **int**| Maximum number of records to return | [default to 10]
 **offset** | **int**| Number of records to skip for pagination | [default to 0]

### Return type

[**List&lt;Wave&gt;**](Wave.md)

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


## GetWavesById

> Wave GetWavesById (string id)

Find a wave by ID

Returns a single wave by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class GetWavesByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InfoApi(Configuration.Default);
            var id = "id_example";  // string | ID of the wave

            try
            {
                // Find a wave by ID
                Wave result = apiInstance.GetWavesById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InfoApi.GetWavesById: " + e.Message );
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
 **id** | **string**| ID of the wave | 

### Return type

[**Wave**](Wave.md)

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

