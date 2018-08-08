using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using Dapper;
using RestSharp;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Class that holds methods to pull data in from the database.
    /// </summary>
    public static class DataAccess
    {
        /// <summary>
        /// Returns the ClientLocations within in the time frame and location specified.
        /// </summary>
        /// <param name="locatedAfterTime">Beginning of the time to get ClientLocations from.</param>
        /// <param name="locatedBeforeTime">End of the time to get ClientLocations from.</param>
        /// <param name="mapHierarchyString">String denoting the location to pull locations from.</param>
        /// <returns>The ClientLocations within the given time frame.</returns>
        public static IEnumerable<ClientLocation> GetClientLocations(long locatedAfterTime, long locatedBeforeTime, string mapHierarchyString)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHandler.CnnVal("Interserv")))
            {
                var locations = connection.Query<ClientLocation>("dbo.proc_Analytics_CLR_NZ_Map @locatedAfterTime, @locatedBeforeTime, @mapHierarchyString", new { locatedAfterTime, locatedBeforeTime, mapHierarchyString });
                return locations;
            }
        }

        /// <summary>
        /// Accesses the CMX API and returns the floor image from the campus, building and floor provided.
        /// </summary>
        /// <param name="url">CMX Url to get data from.</param>
        /// <returns>The content of the response sent by CMX.</returns>
        public static IRestResponse GetContentFromCMX(string url)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", ConnectionHandler.CnnVal("CMX"));
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}