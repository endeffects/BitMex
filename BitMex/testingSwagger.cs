using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;

namespace BitMex
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new APIKeyApi();
            var apiKeyID = "";  // string | API Key ID (public component).

            try
            {
                // Disable an API Key.
                APIKey result = apiInstance.APIKeyDisable(apiKeyID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIKeyApi.APIKeyDisable: " + e.Message);
            }
        }
    }
}
