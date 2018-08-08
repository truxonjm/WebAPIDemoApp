using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    /// <summary>
    /// ClientLocation endpoints.
    /// </summary>
    public class ClientLocationsController : ApiController
    {
        /// <summary>
        /// Returns a list of the ClientLocations that fall within the specified range and within an optional Campus, Building, or Floor.
        /// </summary>
        /// <param name="locatedAfterTime">The lower bound of the range.</param>
        /// <param name="locatedBeforeTime">The upper bound of the range.</param>
        /// <param name="mapHierarchyString">String denoting the location to pull locations from.</param>
        /// <returns>A list of ClientLocations that fall within the specified range.</returns>
        public IEnumerable<ClientLocation> Get(long locatedAfterTime, long locatedBeforeTime, string mapHierarchyString)
        {
            IEnumerable<ClientLocation> output = DataAccess.GetClientLocations(locatedAfterTime, locatedBeforeTime, mapHierarchyString);
            return output;
        }
    }
}
