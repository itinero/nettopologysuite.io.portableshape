using NetTopologySuite.Geometries;
using NetTopologySuite.IO.PortableShape;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometryFactory = new GeometryFactory();
            var reader = new ShapefileDataReader(@"C:\work\osmbe\road-completion-data\Wegenregister_SHAPE_20170323\Shapefile\Wegknoop.shp",
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
