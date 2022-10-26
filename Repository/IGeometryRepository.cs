using TestPostGis.Models;

namespace TestPostGis.Repository
{
    public interface IGeometryRepository
    {
        Task<GeometryDAO> CreatePoint(RequestCreatePoint point);
        Task<GeometryDAO> CreateLineString(RequestCreateLineString lineString);
        Task<GeometryDAO> CreatePolygon(RequestCreatePolygon polygon);
        Task<IList<GeometryDAO>> GetAllGeometries();
    }
}
