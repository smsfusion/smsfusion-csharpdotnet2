using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISMSApi
    {
        /// <summary>
        /// Send an SMS Send one or more SMS
        /// </summary>
        /// <param name="key">API Key as generated from the &lt;a href&#x3D;&#39;https://www.smsfusion.com.au/admin/api/&#39;&gt;admin panel&lt;/a&gt;</param>
        /// <param name="num">Comma separated list of phone numbers or &lt;a href&#x3D;&#39;https://www.smsfusion.com.au/help/msisdn/&#39;&gt;MSDISDN&lt;/a&gt;&#39;s</param>
        /// <param name="msg">Message content to send</param>
        /// <param name="from">MSISDN or vanity alphanumeric source number</param>
        /// <param name="deliverby">UTC encoded time to send the SMS</param>
        /// <param name="dlrcb">HTTP or HTTPS callback URL for delivery reports. Timeout for callbacks is set to 30 seconds</param>
        /// <param name="replycb">HTTP or HTTPS callback URL for replies. Timeout for callbacks is set to 30 seconds</param>
        /// <param name="replyemail">Email address to send replies to</param>
        /// <param name="validity">Time in minutes to keep the SMS valid for</param>
        /// <param name="cc">2 character country code &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-2&#39;&gt;ISO 3166-2&lt;/a&gt; for formatting local numbers internationally</param>
        /// <returns>SMSResult</returns>
        SMSResult SendSMS (string key, List<string> num, string msg, string from, string deliverby, string dlrcb, string replycb, string replyemail, int? validity, string cc);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SMSApi : ISMSApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SMSApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SMSApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Send an SMS Send one or more SMS
        /// </summary>
        /// <param name="key">API Key as generated from the &lt;a href&#x3D;&#39;https://www.smsfusion.com.au/admin/api/&#39;&gt;admin panel&lt;/a&gt;</param> 
        /// <param name="num">Comma separated list of phone numbers or &lt;a href&#x3D;&#39;https://www.smsfusion.com.au/help/msisdn/&#39;&gt;MSDISDN&lt;/a&gt;&#39;s</param> 
        /// <param name="msg">Message content to send</param> 
        /// <param name="from">MSISDN or vanity alphanumeric source number</param> 
        /// <param name="deliverby">UTC encoded time to send the SMS</param> 
        /// <param name="dlrcb">HTTP or HTTPS callback URL for delivery reports. Timeout for callbacks is set to 30 seconds</param> 
        /// <param name="replycb">HTTP or HTTPS callback URL for replies. Timeout for callbacks is set to 30 seconds</param> 
        /// <param name="replyemail">Email address to send replies to</param> 
        /// <param name="validity">Time in minutes to keep the SMS valid for</param> 
        /// <param name="cc">2 character country code &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-2&#39;&gt;ISO 3166-2&lt;/a&gt; for formatting local numbers internationally</param> 
        /// <returns>SMSResult</returns>            
        public SMSResult SendSMS (string key, List<string> num, string msg, string from, string deliverby, string dlrcb, string replycb, string replyemail, int? validity, string cc)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling SendSMS");
            
            // verify the required parameter 'num' is set
            if (num == null) throw new ApiException(400, "Missing required parameter 'num' when calling SendSMS");
            
            // verify the required parameter 'msg' is set
            if (msg == null) throw new ApiException(400, "Missing required parameter 'msg' when calling SendSMS");
            
    
            var path = "/sms/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (num != null) queryParams.Add("num", ApiClient.ParameterToString(num)); // query parameter
 if (msg != null) queryParams.Add("msg", ApiClient.ParameterToString(msg)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (deliverby != null) queryParams.Add("deliverby", ApiClient.ParameterToString(deliverby)); // query parameter
 if (dlrcb != null) queryParams.Add("dlrcb", ApiClient.ParameterToString(dlrcb)); // query parameter
 if (replycb != null) queryParams.Add("replycb", ApiClient.ParameterToString(replycb)); // query parameter
 if (replyemail != null) queryParams.Add("replyemail", ApiClient.ParameterToString(replyemail)); // query parameter
 if (validity != null) queryParams.Add("validity", ApiClient.ParameterToString(validity)); // query parameter
 if (cc != null) queryParams.Add("cc", ApiClient.ParameterToString(cc)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendSMS: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendSMS: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SMSResult) ApiClient.Deserialize(response.Content, typeof(SMSResult), response.Headers);
        }
    
    }
}
