using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace BitMex
{
    public class testingSwagger
    {
        public void main()
        {

            var apiInstance = new APIKeyApi();
            var clientInstance = new ApiClient();
            var apiKeyID = "j4oE_9uKyZerJXWayrtlUVcY";  // string | API Key ID (public component).

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
