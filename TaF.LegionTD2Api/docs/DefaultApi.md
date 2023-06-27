# TaF.LegionTD2Api.Api.DefaultApi

All URIs are relative to *https://apiv2.legiontd2.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PreflightCheck**](DefaultApi.md#preflightcheck) | **OPTIONS** /players/byId/{id} | 
[**PreflightCheck_0**](DefaultApi.md#preflightcheck_0) | **OPTIONS** /players/byName/{name} | 
[**PreflightCheck_1**](DefaultApi.md#preflightcheck_1) | **OPTIONS** /players/bestFriends/{id} | 
[**PreflightCheck_10**](DefaultApi.md#preflightcheck_10) | **OPTIONS** /info/legions/{offset}/{limit} | 
[**PreflightCheck_11**](DefaultApi.md#preflightcheck_11) | **OPTIONS** /info/waves/byId/{id} | 
[**PreflightCheck_12**](DefaultApi.md#preflightcheck_12) | **OPTIONS** /info/waves/{offset}/{limit} | 
[**PreflightCheck_13**](DefaultApi.md#preflightcheck_13) | **OPTIONS** /info/spells/byId/{id} | 
[**PreflightCheck_14**](DefaultApi.md#preflightcheck_14) | **OPTIONS** /info/spells/{offset}/{limit} | 
[**PreflightCheck_15**](DefaultApi.md#preflightcheck_15) | **OPTIONS** /info/abilities/byId/{id} | 
[**PreflightCheck_16**](DefaultApi.md#preflightcheck_16) | **OPTIONS** /info/abilities/{offset}/{limit} | 
[**PreflightCheck_17**](DefaultApi.md#preflightcheck_17) | **OPTIONS** /info/research/byId/{id} | 
[**PreflightCheck_18**](DefaultApi.md#preflightcheck_18) | **OPTIONS** /info/research/{offset}/{limit} | 
[**PreflightCheck_19**](DefaultApi.md#preflightcheck_19) | **OPTIONS** /info/descriptions/{id} | 
[**PreflightCheck_2**](DefaultApi.md#preflightcheck_2) | **OPTIONS** /players/matchHistory/{id} | 
[**PreflightCheck_3**](DefaultApi.md#preflightcheck_3) | **OPTIONS** /players/stats/{id} | 
[**PreflightCheck_4**](DefaultApi.md#preflightcheck_4) | **OPTIONS** /players/stats | 
[**PreflightCheck_5**](DefaultApi.md#preflightcheck_5) | **OPTIONS** /units/byId/{id} | 
[**PreflightCheck_6**](DefaultApi.md#preflightcheck_6) | **OPTIONS** /units/byName/{name} | 
[**PreflightCheck_7**](DefaultApi.md#preflightcheck_7) | **OPTIONS** /games | 
[**PreflightCheck_8**](DefaultApi.md#preflightcheck_8) | **OPTIONS** /info/legions/byId/{id} | 
[**PreflightCheck_9**](DefaultApi.md#preflightcheck_9) | **OPTIONS** /games/byId/{id} | 
[**UnitsByVersionVersionOptions**](DefaultApi.md#unitsbyversionversionoptions) | **OPTIONS** /units/byVersion/{version} | 



## PreflightCheck

> void PreflightCheck (string id = null, string name = null, string version = null, string offset = null, string limit = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheckExample
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

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID | [optional] 
 **name** | **string**| Name | [optional] 
 **version** | **string**| Version | [optional] 
 **offset** | **string**| Offset | [optional] 
 **limit** | **string**| Limit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 200 response |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_0

> void PreflightCheck_0 (string name = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_0Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var name = "name_example";  // string | Name of the player (optional) 

            try
            {
                apiInstance.PreflightCheck_0(name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_0: " + e.Message );
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
 **name** | **string**| Name of the player | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_1

> void PreflightCheck_1 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | Account ID of the player (optional) 

            try
            {
                apiInstance.PreflightCheck_1(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_1: " + e.Message );
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
 **id** | **string**| Account ID of the player | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_10

> void PreflightCheck_10 (string limit, string offset)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_10Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var limit = "limit_example";  // string | Limit
            var offset = "offset_example";  // string | Offset

            try
            {
                apiInstance.PreflightCheck_10(limit, offset);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_10: " + e.Message );
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
 **limit** | **string**| Limit | 
 **offset** | **string**| Offset | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_11

> void PreflightCheck_11 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_11Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the wave (optional) 

            try
            {
                apiInstance.PreflightCheck_11(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_11: " + e.Message );
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
 **id** | **string**| ID of the wave | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_12

> void PreflightCheck_12 (string limit, string offset)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_12Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var limit = "limit_example";  // string | Limit
            var offset = "offset_example";  // string | Offset

            try
            {
                apiInstance.PreflightCheck_12(limit, offset);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_12: " + e.Message );
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
 **limit** | **string**| Limit | 
 **offset** | **string**| Offset | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_13

> void PreflightCheck_13 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_13Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the spell (optional) 

            try
            {
                apiInstance.PreflightCheck_13(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_13: " + e.Message );
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
 **id** | **string**| ID of the spell | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_14

> void PreflightCheck_14 (string limit, string offset)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_14Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var limit = "limit_example";  // string | Limit
            var offset = "offset_example";  // string | Offset

            try
            {
                apiInstance.PreflightCheck_14(limit, offset);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_14: " + e.Message );
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
 **limit** | **string**| Limit | 
 **offset** | **string**| Offset | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_15

> void PreflightCheck_15 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_15Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the ability (optional) 

            try
            {
                apiInstance.PreflightCheck_15(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_15: " + e.Message );
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
 **id** | **string**| ID of the ability | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_16

> void PreflightCheck_16 (string limit, string offset)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_16Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var limit = "limit_example";  // string | Limit
            var offset = "offset_example";  // string | Offset

            try
            {
                apiInstance.PreflightCheck_16(limit, offset);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_16: " + e.Message );
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
 **limit** | **string**| Limit | 
 **offset** | **string**| Offset | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_17

> void PreflightCheck_17 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_17Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the research (optional) 

            try
            {
                apiInstance.PreflightCheck_17(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_17: " + e.Message );
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
 **id** | **string**| ID of the research | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_18

> void PreflightCheck_18 (string limit, string offset)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_18Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var limit = "limit_example";  // string | Limit
            var offset = "offset_example";  // string | Offset

            try
            {
                apiInstance.PreflightCheck_18(limit, offset);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_18: " + e.Message );
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
 **limit** | **string**| Limit | 
 **offset** | **string**| Offset | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_19

> void PreflightCheck_19 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_19Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the description (optional) 

            try
            {
                apiInstance.PreflightCheck_19(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_19: " + e.Message );
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
 **id** | **string**| ID of the description | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_2

> void PreflightCheck_2 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | Account ID of the player (optional) 

            try
            {
                apiInstance.PreflightCheck_2(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_2: " + e.Message );
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
 **id** | **string**| Account ID of the player | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_3

> void PreflightCheck_3 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_3Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | Account ID of the player (optional) 

            try
            {
                apiInstance.PreflightCheck_3(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_3: " + e.Message );
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
 **id** | **string**| Account ID of the player | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_4

> void PreflightCheck_4 ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_4Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                apiInstance.PreflightCheck_4();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_4: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_5

> void PreflightCheck_5 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_5Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the unit (optional) 

            try
            {
                apiInstance.PreflightCheck_5(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_5: " + e.Message );
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
 **id** | **string**| ID of the unit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_6

> void PreflightCheck_6 (string name = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_6Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var name = "name_example";  // string | Name of the Unit (optional) 

            try
            {
                apiInstance.PreflightCheck_6(name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_6: " + e.Message );
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
 **name** | **string**| Name of the Unit | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_7

> void PreflightCheck_7 (string version = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_7Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var version = "version_example";  // string | Patch Version of the match (optional) 

            try
            {
                apiInstance.PreflightCheck_7(version);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_7: " + e.Message );
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
 **version** | **string**| Patch Version of the match | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_8

> void PreflightCheck_8 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_8Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the legion (optional) 

            try
            {
                apiInstance.PreflightCheck_8(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_8: " + e.Message );
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
 **id** | **string**| ID of the legion | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PreflightCheck_9

> void PreflightCheck_9 (string id = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class PreflightCheck_9Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);
            var id = "id_example";  // string | ID of the match (optional) 

            try
            {
                apiInstance.PreflightCheck_9(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PreflightCheck_9: " + e.Message );
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
 **id** | **string**| ID of the match | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnitsByVersionVersionOptions

> void UnitsByVersionVersionOptions ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TaF.LegionTD2Api.Api;
using TaF.LegionTD2Api.Client;
using TaF.LegionTD2Api.Model;

namespace Example
{
    public class UnitsByVersionVersionOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://apiv2.legiontd2.com";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                apiInstance.UnitsByVersionVersionOptions();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.UnitsByVersionVersionOptions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * Access-Control-Allow-Origin -  <br>  * Access-Control-Allow-Methods -  <br>  * Access-Control-Allow-Headers -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

