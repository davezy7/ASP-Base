using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestPostGis.Models
{
    public class GeometryDAO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }

        public string? Name { get; set; }

        public Geometry? DataGeometry { get; set; }

    }

    public class RequestCreatePoint
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    public class RequestCreateLineString
    {
        public RequestCreatePoint? PointA { get; set; }
        public RequestCreatePoint? PointB { get; set; }
    }

    public class RequestCreatePolygon
    {
        public RequestCreatePoint? PointA { get; set; }
        public RequestCreatePoint? PointB { get; set; }
        public RequestCreatePoint? PointC { get; set; }
    }
}
