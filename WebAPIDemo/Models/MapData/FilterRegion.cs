using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains information about a FilterRegion.
    /// </summary>
    public class FilterRegion
    {
        /// <summary>
        /// Type of region.
        /// </summary>
        public string regionType { get; set; }
        /// <summary>
        /// List of coordinates that make up the FilterRegion.
        /// </summary>
        public IEnumerable<Coordinate> regionCoordinates { get; set; }
        /// <summary>
        /// If the region is default.
        /// </summary>
        public bool isDefault { get; set; }
    }
}