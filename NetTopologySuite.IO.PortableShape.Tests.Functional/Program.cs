using NetTopologySuite.Geometries;
using NetTopologySuite.IO.PortableShape;
using System;
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

            while (reader.Read())
            {
                Console.WriteLine(reader.Geometry);

                for (var i = 0; i < header.Fields.Length; i++)
                {
                    Console.WriteLine(reader.GetValue(i));
                }
            }
        }
    }
}
