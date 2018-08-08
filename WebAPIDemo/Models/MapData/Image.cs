using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains parent object image information.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Name of the image.
        /// </summary>
        public string imageName { get; set; }
        /// <summary>
        /// Zoom level of the image.
        /// </summary>
        public float zoomLevel { get; set; }
        /// <summary>
        /// Width of the image in pixels.
        /// </summary>
        public float width { get; set; }
        /// <summary>
        /// Height of the image in pixels.
        /// </summary>
        public float height { get; set; }
        /// <summary>
        /// Max of the height and width. Used in scaling calculations.
        /// </summary>
        public float size { get; set; }
        /// <summary>
        /// Maximum resolution of the image.
        /// </summary>
        public float maxResolution { get; set; }
        /// <summary>
        /// Color depth of the image.
        /// </summary>
        public float colorDepth { get; set; }
    }
}