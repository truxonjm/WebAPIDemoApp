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
    /// FloorImage endpoints.
    /// </summary>
    public class FloorImageController : ApiController
    {
        /// <summary>
        /// Returns floor image specified by Campus, Building and Floor.
        /// </summary>
        /// <param name="mapCampus">Campus containing floor.</param>
        /// <param name="mapBuilding">Building containing floor.</param>
        /// <param name="mapFloor">Floor name.</param>
        /// <returns>String containing the base64 data of the map image.</returns>
        public string Get(string mapCampus, string mapBuilding, string mapFloor)
        {
            /*string responseData = DataAccess.GetContentFromCMX("https://dcciscocmx.cmog.org/api/config/v1/maps/image/Corning%20Museum%20of%20Glass/Corning%20Museum%20of%20Glass/Museum%20Second%20Floor").Content;
            return "data:image/jpeg;base64, " + responseData;*/
            return "Content/Images/museum_floor2.jpg";
        }
    }
}