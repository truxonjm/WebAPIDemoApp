using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains information about an AccessPoint.
    /// </summary>
    public class AccessPoint
    {
        /// <summary>
        /// Type of AP.
        /// </summary>
        public int apType { get; set; }
        /// <summary>
        /// Number of slots in AccessPoint.
        /// </summary>
        public int numOfSlots { get; set; }
        /// <summary>
        /// Id of the floor.
        /// </summary>
        public long floorId { get; set; }
        /// <summary>
        /// Angle of the AccessPoint.
        /// </summary>
        public float angle { get; set; }
        /// <summary>
        /// Switch name.
        /// </summary>
        public string switchName { get; set; }
        /// <summary>
        /// Name of the AccessPoint.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Radio mac address of the AccessPoint.
        /// </summary>
        public string radioMacAddress { get; set; }
        /// <summary>
        /// Eth mac Address of the AccessPoint.
        /// </summary>
        public string ethMacAddress { get; set; }
        /// <summary>
        /// IP address of the AccessPoint.
        /// </summary>
        public string ipAddress { get; set; }
        /// <summary>
        /// ApMode of the AccessPoint.
        /// </summary>
        public string apMode { get; set; }
        /// <summary>
        /// Floor id string of the AccessPoint.
        /// </summary>
        public string floorIdString { get; set; }
        /// <summary>
        /// Details about the AccessPoint.
        /// </summary>
        public string deviceDetails { get; set; }
        /// <summary>
        /// GeoCoordinate of the AccessPoint.
        /// </summary>
        public Coordinate geoCoordinate { get; set; }
        /// <summary>
        /// Coordinates on the map of the AccessPoint.
        /// </summary>
        public Coordinate mapCoordinates { get; set; }
        /// <summary>
        /// List if all APInterfaces associated with the AccessPoint.
        /// </summary>
        public IEnumerable<APInterface> apInterfaces { get; set; }
    }
}