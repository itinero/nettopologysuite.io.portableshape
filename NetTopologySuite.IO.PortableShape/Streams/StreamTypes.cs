using System;
using System.Collections.Generic;
using System.Text;

namespace NetTopologySuite.IO.PortableShape.Streams
{
    /// <summary>
    /// An enumeration of stream types
    /// </summary>
    public static class StreamTypes
    {
        /// <summary>
        /// A shape stream (*.shp)
        /// </summary>
        public const string Shape = "SHAPESTREAM";
        /// <summary>
        /// An index stream (*.shx)
        /// </summary>
        public const string Index = "INDEXSTREAM";
        /// <summary>
        /// A projection string (*.prj)
        /// </summary>
        public const string Projection = "PROJECTIONSTREAM";

        /// <summary>
        /// A data stream (*.dbf)
        /// </summary>
        public const string Data = "DATASTREAM";
        /// <summary>
        /// A data encoding stream (*.cpg)
        /// </summary>
        public const string DataEncoding = "DATAENCODINGSTREAM";

        /// <summary>
        /// A spatial index stream (*.sbn)
        /// </summary>
        public const string SpatialIndex = "SPATIALINDEXSTREAM";
        /// <summary>
        /// A spatial index index stream (*.sbx)
        /// </summary>
        public const string SpatialIndexIndex = "SPATIALINDEXINDEXSTREAM";
    }
}
