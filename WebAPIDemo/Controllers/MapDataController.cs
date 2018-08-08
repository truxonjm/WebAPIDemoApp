using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers.Maps
{
    /// <summary>
    /// Provides access to the MapData from CMX.
    /// </summary>
    public class MapDataController : ApiController
    {
        /// <summary>
        /// Returns the data for all maps.
        /// </summary>
        /// <returns></returns>
        public MapData Get()
        {
            string responseData = DataAccess.GetContentFromCMX("https://dcciscocmx.cmog.org/api/config/v1/maps").Content;
            MapData data = JsonConvert.DeserializeObject<MapData>(responseData);
            return data;
        }
    }
}
