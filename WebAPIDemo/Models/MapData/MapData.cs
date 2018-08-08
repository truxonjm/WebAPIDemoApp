using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// This API returns all maps.
    /// </summary>
    public class MapData
    {
        /// <summary>
        /// API Version.
        /// </summary>
        public int version { get; set; }
        /// <summary>
        /// All Campuses.
        /// </summary>
        public IEnumerable<Campus> campuses { get; set; }
    }
}