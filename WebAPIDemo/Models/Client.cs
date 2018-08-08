using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    /// <summary>
    /// Represents a single Client datapoint
    /// </summary>
    public class Client
    {
        /// <summary>
        /// SQL Server id
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// MacAddress of the user
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// String containing the heirarchy
        /// </summary>
        public string MapHierarchyString { get; set; }
        public string MapCampus { get; set; }
        public string MapBuilding { get; set; }
        public string MapFloor { get; set; }
        public string MapZones { get; set; }
        public int MapCoordinateX { get; set; }
        public int MapCoordinateY { get; set; }
        public int MapCoordinateZ { get; set; }
        public string MapCoordinateUnit { get; set; }
        public string CurrentlyTracked { get; set; }
        public int ConfidenceFactor { get; set; }
        public string LocComputeType { get; set; }
        public DateTime CurrentServerTime { get; set; }
        public DateTime FirstLocatedTime { get; set; }
        public DateTime LastLocatedTime { get; set; }
        public string HistoryLogReason { get; set; }
        public string GeoCoordinate { get; set; }
        public string RawLocation { get; set; }
        public string NetworkStatus { get; set; }
        public Int64 ChangedOn { get; set; }
        public string IpAddress { get; set; }
        public string UserName { get; set; }
        public string SsId { get; set; }
        public Int64 SourceTimestamp { get; set; }
        public string Band { get; set; }
        public string ApMacAddress { get; set; }
        public string Dot11Status { get; set; }
        public string Manufacturer { get; set; }
        public string AreaGlobalIdList { get; set; }
        public string DetectingControllers { get; set; }
        public Int64 BytesSent { get; set; }
        public Int64 BytesReceived { get; set; }
        public string GuestUser { get; set; }
        public int RequestLogID { get; set; }
    }
}