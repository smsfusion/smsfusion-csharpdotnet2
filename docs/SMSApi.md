# IO.Swagger..SMSApi

All URIs are relative to *https://api.smsfusion.com.au/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendSMS**](SMSApi.md#sendsms) | **GET** /sms/ | Send an SMS


<a name="sendsms"></a>
# **SendSMS**
> SMSResult SendSMS (string key, List<string> num, string msg, string from, string deliverby, string dlrcb, string replycb, string replyemail, int? validity, string cc)

Send an SMS

Send one or more SMS

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendSMSExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new SMSApi();
            var key = key_example;  // string | API Key as generated from the <a href='https://www.smsfusion.com.au/admin/api/'>admin panel</a>
            var num = new List<string>(); // List<string> | Comma separated list of phone numbers or <a href='https://www.smsfusion.com.au/help/msisdn/'>MSDISDN</a>'s
            var msg = msg_example;  // string | Message content to send
            var from = from_example;  // string | MSISDN or vanity alphanumeric source number (optional) 
            var deliverby = deliverby_example;  // string | UTC encoded time to send the SMS (optional) 
            var dlrcb = dlrcb_example;  // string | HTTP or HTTPS callback URL for delivery reports. Timeout for callbacks is set to 30 seconds (optional) 
            var replycb = replycb_example;  // string | HTTP or HTTPS callback URL for replies. Timeout for callbacks is set to 30 seconds (optional) 
            var replyemail = replyemail_example;  // string | Email address to send replies to (optional) 
            var validity = 56;  // int? | Time in minutes to keep the SMS valid for (optional) 
            var cc = cc_example;  // string | 2 character country code <a href='https://en.wikipedia.org/wiki/ISO_3166-2'>ISO 3166-2</a> for formatting local numbers internationally (optional) 

            try
            {
                // Send an SMS
                SMSResult result = apiInstance.SendSMS(key, num, msg, from, deliverby, dlrcb, replycb, replyemail, validity, cc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMSApi.SendSMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| API Key as generated from the &lt;a href&#x3D;&#39;https://www.smsfusion.com.au/admin/api/&#39;&gt;admin panel&lt;/a&gt; | 
 **num** | [**List<string>**](string.md)| Comma separated list of phone numbers or &lt;a href&#x3D;&#39;https://www.smsfusion.com.au/help/msisdn/&#39;&gt;MSDISDN&lt;/a&gt;&#39;s | 
 **msg** | **string**| Message content to send | 
 **from** | **string**| MSISDN or vanity alphanumeric source number | [optional] 
 **deliverby** | **string**| UTC encoded time to send the SMS | [optional] 
 **dlrcb** | **string**| HTTP or HTTPS callback URL for delivery reports. Timeout for callbacks is set to 30 seconds | [optional] 
 **replycb** | **string**| HTTP or HTTPS callback URL for replies. Timeout for callbacks is set to 30 seconds | [optional] 
 **replyemail** | **string**| Email address to send replies to | [optional] 
 **validity** | **int?**| Time in minutes to keep the SMS valid for | [optional] 
 **cc** | **string**| 2 character country code &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-2&#39;&gt;ISO 3166-2&lt;/a&gt; for formatting local numbers internationally | [optional] 

### Return type

[**SMSResult**](SMSResult.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

