# IO.Swagger - the C# library for the SMS Fusion API

This is the SMS Fusion API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build date: 2017-05-04T01:27:00.380-07:00
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen
    For more information, please visit [https://www.smsfusion.com.au/help/](https://www.smsfusion.com.au/help/)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.IO.Swagger.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new DefaultApi();
            var key = key_example;  // string | API Key as generated from the <a href='https://www.smsfusion.com.au/admin/api/'>admin panel</a>
            var num = num_example;  // string | A single phone number or <a href='https://www.smsfusion.com.au/help/msisdn/'>MSDISDN</a>
            var cc = cc_example;  // string | 2 character country code <a href='https://en.wikipedia.org/wiki/ISO_3166-2'>ISO 3166-2</a> for formatting local numbers internationally (optional) 

            try
            {
                // HLR number lookup
                HLRCallback result = apiInstance.GetHLR(key, num, cc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetHLR: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://api.smsfusion.com.au/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**GetHLR**](docs/DefaultApi.md#gethlr) | **GET** /hlr/ | HLR number lookup
*DefaultApi* | [**GetHLRCallback**](docs/DefaultApi.md#gethlrcallback) | **GET** /hlr-callback/ | HLR number lookup with results going to a callback URL


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.HLRCallback](docs/HLRCallback.md)
 - [IO.Swagger.Model.HLRError](docs/HLRError.md)
 - [IO.Swagger.Model.HLRResult](docs/HLRResult.md)
 - [IO.Swagger.Model.OutOfCredit](docs/OutOfCredit.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: key
- **Location**: URL query string

