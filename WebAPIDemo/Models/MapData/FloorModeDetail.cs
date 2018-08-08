using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains details about parent object's mode.
    /// </summary>
    public class FloorModeDetail
    {
        /// <summary>
        /// Type of mode.
        /// </summary>
        public string mode { get; set; }
        /// <summary>
        /// If the requested mode is set.
        /// </summary>
        public bool requestedModeSet { get; set; }
    }
}