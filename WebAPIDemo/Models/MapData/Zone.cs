using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains information about a zone.
    /// </summary>
    public class Zone
    {
        /// <summary>
        /// Name of the zone.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The coordinates that make up the zone.
        /// </summary>
        public IEnumerable<Coordinate> zoneCoordinate { get; set; }
        /// <summary>
        /// Type of zone.
        /// </summary>
        public string zoneType { get; set; }
    }
}