using System;
using System.Net.Http;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp3
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            try
            {
                log.Info("testing with only azure.identity 1.3");
                AccessToken token = new DefaultAzureCredential().GetToken(new TokenRequestContext());
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
            }
            return null;
        }
    }
}
