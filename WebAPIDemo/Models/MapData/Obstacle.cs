using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains information about an obstacle.
    /// </summary>
    public class Obstacle
    {
        /// <summary>
        /// Name of the Obstacle.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Attenuation of the obstacle.
        /// </summary>
        public float attenuation { get; set; }
        /// <summary>
        /// List of coordinates that make up the obstacle.
        /// </summary>
        public IEnumerable<Coordinate> obstacleCoordinates { get; set; }
    }
}