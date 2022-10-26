using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestPostGis.Models;
using TestPostGis.Repository;

namespace TestPostGis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeometryController : ControllerBase
    {
        private readonly IGeometryRepository _repository;

        public GeometryController(IGeometryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGeometries()
        {
            var result = await _repository.GetAllGeometries();
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost("createpoint")]
        public async Task<IActionResult> CreatePoint(RequestCreatePoint coordinate)
        {
            var result = await _repository.CreatePoint(coordinate);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost("createlinestring")]
        public async Task<IActionResult> CreateLineString(RequestCreateLineString coordinate)
        {
            var result = await _repository.CreateLineString(coordinate);
            return result == null ? BadRequest() : Ok(result);
        }

        [HttpPost("createpolygon")]
        public async Task<IActionResult> CreatePolygon(RequestCreatePolygon coordinate)
        {
            var result = await _repository.CreatePolygon(coordinate);
            return result == null ? BadRequest() : Ok(result);
        }
    }
}
