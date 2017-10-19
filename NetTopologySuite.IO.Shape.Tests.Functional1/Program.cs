using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTopologySuite.IO.Shape.Tests.Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new ShapefileDataReader(@"C:\work\osmbe\road-completion-data\Wegenregister_SHAPE_20170323\Shapefile\Wegknoop.shp", new GeometryFactory());

            while (reader.Read())
            {
                Console.WriteLine(reader.Geometry);
            }
        }
    }
}
