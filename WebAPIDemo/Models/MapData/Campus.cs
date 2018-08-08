using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Hold information about a campus.
    /// </summary>
    public class Campus
    {
        /// <summary>
        /// Object version.
        /// </summary>
        public int objectVersion { get; set; }
        /// <summary>
        /// Campus name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Campus dimension.
        /// </summary>
        public Dimension dimension { get; set; }
        /// <summary>
        /// Campus Image.
        /// </summary>
        public Image image { get; set; }
        /// <summary>
        /// List of all Buildings on campus.
        /// </summary>
        public IEnumerable<Building> buildingList { get; set; }
        /// <summary>
        /// AesUid of Campus.
        /// </summary>
        public float aesUid { get; set; }
        /// <summary>
        /// String representation of the aedUid of the campus.
        /// </summary>
        public string aesUidString { get; set; }
        /// <summary>
        /// List of all members of campus.
        /// </summary>
        public IEnumerable<Member> members { get; set; }
    }
}