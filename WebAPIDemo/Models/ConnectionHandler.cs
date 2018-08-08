using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains general functions to assist with database access.
    /// </summary>
    public static class ConnectionHandler
    {
        /// <summary>
        /// Configuration connection string retirever.
        /// </summary>
        /// <param name="name">Server name to obtain connection string for.</param>
        /// <returns>Connection string specific to that server.</returns>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}