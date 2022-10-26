using TestPostGis.Models;

namespace TestPostGis.Repository
{
    public interface IGeometryRepository
    {
        Task<GeometryDAO> CreatePoint(RequestCreatePoint point);
        Task<GeometryDAO> CreateLineString(RequestCreatePoint pointA, RequestCreatePoint pointB);
        Task<GeometryDAO> CreatePolygon(RequestCreatePoint pointA, RequestCreatePoint pointB, RequestCreatePoint pointC);
    }
}
