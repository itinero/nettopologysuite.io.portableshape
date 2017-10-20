using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO.PortableShape;
using System;
using System.Collections.Generic;
using System.IO;

namespace NetTopologySuite.IO.PortableShape.Tests.Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometryFactory = new GeometryFactory();
            var reader = new ShapefileDataReader(Path.Combine("..", "data", "refpunt.shp"),
                geometryFactory);

            var header = reader.DbaseHeader;

            var features = new List<IFeature>();
            while (reader.Read())
            {
                Console.WriteLine(reader.Geometry);

                for (var i = 0; i < header.NumFields; i++)
                {
                    Console.WriteLine("{0} - {1}", header.Fields[i].Name, reader.GetValue(i + 1));
                }

                var feature = reader.Feature;

                features.Add(feature);
            }

            var writer = new ShapefileDataWriter("temp.shp")
            {
                Header = header
            };
            writer.Write(features);
        }
    }
}
