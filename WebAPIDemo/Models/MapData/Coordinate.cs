using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains a coordinate for parent object.
    /// </summary>
    public class Coordinate
    {
        /// <summary>
        /// X value of the coordinate.
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Y value of the coordinate.
        /// </summary>
        public float y { get; set; }
        /// <summary>
        /// Z value of the coordinate.
        /// </summary>
        public float z { get; set; }
        /// <summary>
        /// Unit of the coordinate.
        /// </summary>
        public string unit { get; set; }
    }
}