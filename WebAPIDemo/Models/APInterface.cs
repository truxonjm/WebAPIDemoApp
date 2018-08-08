using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Contains information about an APInterface.
    /// </summary>
    public class APInterface
    {
        /// <summary>
        /// The dual band slot of the APInterface.
        /// </summary>
        public bool dualBandSlot { get; set; }
        /// <summary>
        /// The slot number of the APInterface.
        /// </summary>
        public int slotNumber { get; set; }
        /// <summary>
        /// The channel assignment of the APInterface.
        /// </summary>
        public int channelAssignment { get; set; }
        /// <summary>
        /// The channel number of the APInterface.
        /// </summary>
        public int channelNumber { get; set; }
        /// <summary>
        /// The tx power level of the APInterface.
        /// </summary>
        public int txPowerLevel { get; set; }
        /// <summary>
        /// The tx power control of the APInterface.
        /// </summary>
        public int txPowerControl { get; set; }
        /// <summary>
        /// The antenna diversity of the APInterface.
        /// </summary>
        public int antennaDiversity { get; set; }
        /// <summary>
        /// The antenna mode of the APInterface.
        /// </summary>
        public int antennaMode { get; set; }
        /// <summary>
        /// The antenna type of the APInterface.
        /// </summary>
        public int antennaType { get; set; }
        /// <summary>
        /// The antenna angle of the APInterface.
        /// </summary>
        public float antennaAngle { get; set; }
        /// <summary>
        /// The antenna elevation angle of the APInterface.
        /// </summary>
        public float antennaElevAngle { get; set; }
        /// <summary>
        /// The antenna gain of the APInterface.
        /// </summary>
        public float antennaGain { get; set; }
        /// <summary>
        /// The band of the APInterface.
        /// </summary>
        public string band { get; set; }
        /// <summary>
        /// The antenna patter of the APInterface.
        /// </summary>
        public string antennaPattern { get; set; }
        /// <summary>
        /// The unit of the APInterface.
        /// </summary>
        public string unit { get; set; }
        
    }
}