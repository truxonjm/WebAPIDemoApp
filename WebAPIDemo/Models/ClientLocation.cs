using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Represents a single ClientLocation datapoint.
    /// </summary>
    public class ClientLocation
    {
        /// <summary>
        /// X coordinate on map.
        /// </summary>
        public float MapCoordinateX { get; set; }
        /// <summary>
        /// Y coordinate on map.
        /// </summary>
        public float MapCoordinateY { get; set; }
        /// <summary>
        /// Confidence factor for point accuracy.
        /// </summary>
        public int ConfidenceFactor { get; set; }
    }
}