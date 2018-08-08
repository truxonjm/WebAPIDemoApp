using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIDemo.Models;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains information about the floor.
    /// </summary>
    public class Floor
    {
        /// <summary>
        /// Object version.
        /// </summary>
        public int objectVersion { get; set; }
        /// <summary>
        /// Floor name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// ID of the calibration model of the floor.
        /// </summary>
        public float calibrationModelId { get; set; }
        /// <summary>
        /// AedUid of the floor.
        /// </summary>
        public float aesUid { get; set; }
        /// <summary>
        /// String representation of the aedUid of the floor.
        /// </summary>
        public string aesUidString { get; set; }
        /// <summary>
        /// Hierarchy string showing parent Campus and Building.
        /// </summary>
        public string hierarchyName { get; set; }
        /// <summary>
        /// If the floor is outdoors or inside a building.
        /// </summary>
        public bool isOutdoor { get; set; }
        /// <summary>
        /// The floor number in the building.
        /// </summary>
        public int floorNumber { get; set; }
        /// <summary>
        /// States the geolocation capabilities of floor.
        /// </summary>
        public string geoLocationCapable { get; set; }
        /// <summary>
        /// Mode of the floor.
        /// </summary>
        public object mode { get; set; }
        /// <summary>
        /// Object containing the floor mode details.
        /// </summary>
        public FloorModeDetail floorModeDetails { get; set; }
        /// <summary>
        /// Floor dimension.
        /// </summary>
        public Dimension dimension { get; set; }
        /// <summary>
        /// Floor Image.
        /// </summary>
        public Image image { get; set; }
        /// <summary>
        /// List of all GpsMarkers on floor.
        /// </summary>
        public IEnumerable<GpsMarker> gpsMarkers { get; set; }
        /// <summary>
        /// List of all Zones on floor.
        /// </summary>
        public IEnumerable<Zone> zones { get; set; }
        /// <summary>
        /// List of all Obstacles on floor.
        /// </summary>
        public IEnumerable<Obstacle> obstacles { get; set; }
        /// <summary>
        /// List of all AccessPoints on floor.
        /// </summary>
        public IEnumerable<AccessPoint> accessPoints { get; set; }
        /// <summary>
        /// List of all ReferenceMarkers on floor.
        /// </summary>
        public IEnumerable<ReferenceMarker> referenceMarkers { get; set; }
        /// <summary>
        /// List of all FilterRegions on floor.
        /// </summary>
        public IEnumerable<FilterRegion> filterRegions { get; set; }
        /// <summary>
        /// List of all FilterRails on floor.
        /// </summary>
        public IEnumerable<FilterRail> filterRails { get; set; }
        /// <summary>
        /// List of all Exciters on floor.
        /// </summary>
        public IEnumerable<Exciter> exciters { get; set; }
        
    }
}