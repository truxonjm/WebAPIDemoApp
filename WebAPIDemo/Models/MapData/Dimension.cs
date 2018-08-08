using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains campus dimension data about the parent object.
    /// </summary>
    public class Dimension
    {
        /// <summary>
        /// Length of parent object in units.
        /// </summary>
        public float length { get; set; }
        /// <summary>
        /// Width of parent object in units.
        /// </summary>
        public float width { get; set; }
        /// <summary>
        /// Height of parent object in units.
        /// </summary>
        public float height { get; set; }
        /// <summary>
        /// X-Offset of the parent object in units.
        /// </summary>
        public float offsetX { get; set; }
        /// <summary>
        /// Y-Offset of the parent object in units.
        /// </summary>
        public float offsetY { get; set; }
        /// <summary>
        /// Unit used for measurement.
        /// </summary>
        public string unit { get; set; }
    }
}