using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Holds information about a Building.
    /// </summary>
    public class Building
    {
        /// <summary>
        /// Object version.
        /// </summary>
        public int objectVersion { get; set; }
        /// <summary>
        /// Building name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Building dimension.
        /// </summary>
        public Dimension dimension { get; set; }
        /// <summary>
        /// Building Image.
        /// </summary>
        public Image image { get; set; }
        /// <summary>
        /// List of all floors in building.
        /// </summary>
        public IEnumerable<Floor> floorList { get; set; }
        /// <summary>
        /// AedUid of the building.
        /// </summary>
        public float aesUid { get; set; }
        /// <summary>
        /// String representation of the aedUid of the building.
        /// </summary>
        public string aesUidString { get; set; }
        /// <summary>
        /// Hierarchy string showing parent campus.
        /// </summary>
        public string hierarchyName { get; set; }
    }
}