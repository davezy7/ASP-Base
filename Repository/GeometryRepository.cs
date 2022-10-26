using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using TestPostGis.Models;

namespace TestPostGis.Repository
{
    public class GeometryRepository : IGeometryRepository
    {
        private readonly BEDBContext _dbContext;

        public GeometryRepository(BEDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GeometryDAO> CreateLineString(RequestCreateLineString lineString)
        {
            var coordinateA = new Coordinate(lineString.PointA.Latitude, lineString.PointA.Longitude);
            var coordinateB = new Coordinate(lineString.PointB.Latitude, lineString.PointB.Longitude);
            var arrayCoordinate = new Coordinate[2] {coordinateA, coordinateB };
            var newLineString = new LineString(arrayCoordinate);
            var newDao = new GeometryDAO
            {
                Name = $"LineString {lineString.PointA.Latitude}",
                DataGeometry = newLineString
            };
            await _dbContext.Geometries.AddAsync(newDao);
            await _dbContext.SaveChangesAsync();
            return newDao;
        }

        public async Task<GeometryDAO> CreatePoint(RequestCreatePoint point)
        {
            var coordinate = new Coordinate(point.Latitude, point.Longitude);
            var newPoint = new Point(coordinate);
            var newDao = new GeometryDAO
            {
                Name = $"Point {point.Latitude}",
                DataGeometry = newPoint
            };
            await _dbContext.Geometries.AddAsync(newDao);
            await _dbContext.SaveChangesAsync();
            return newDao;
        }

        public async Task<GeometryDAO> CreatePolygon(RequestCreatePolygon polygon)
        {
            var pointA = polygon.PointA;
            var pointB = polygon.PointB;
            var pointC = polygon.PointC;

            var coordinateA = new Coordinate(pointA.Latitude, pointA.Longitude);
            var coordinateB = new Coordinate(pointB.Latitude, pointB.Longitude);
            var coordinateC = new Coordinate(pointC.Latitude, pointB.Longitude);
            var arrayCoordinate = new Coordinate[4] { coordinateA, coordinateB, coordinateC, coordinateA }; // Line has to be closed (original point/coordinate)
            var polygonShell = new LinearRing(arrayCoordinate);
            var newPolygon = new Polygon(polygonShell);
            var newDao = new GeometryDAO
            {
                Name = $"Polygon {pointA.Latitude}",
                DataGeometry = newPolygon
            };
            await _dbContext.Geometries.AddAsync(newDao);
            await _dbContext.SaveChangesAsync();
            return newDao;
        }

        public async Task<IList<GeometryDAO>> GetAllGeometries()
        {
            return await _dbContext.Geometries.ToListAsync();
        }
    }
}
