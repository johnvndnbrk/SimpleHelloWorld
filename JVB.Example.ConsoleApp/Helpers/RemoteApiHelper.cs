using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JVB.Example.ConsoleApp.Models;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;

namespace JVB.Example.ConsoleApp.Helpers
{
    internal static class RemoteApiHelper
    {
        /// <summary>
        /// Gets the reference data asynchronous.
        /// </summary>
        /// <returns>QuickQuoteReferenceData.</returns>
        public static WelcomeMessage GetHelloMessage()
        {
            var client = new RestClient(ConfigurationManager.AppSettings["remoteBaseUrl"]);
            var request = new RestRequest("api/welcomemessage/getgreeting", Method.GET);

            var response = client.Execute(request);

            //special characters are escaped. this is to correct for this.
            //var g = StringHelper.RemoveExtraEscapeCharacters(response);

            //used to deserialize objects
            var results = JsonConvert.DeserializeObject<WelcomeMessage>(response.Content);

            return results;

        }


    }
}
