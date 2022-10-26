using Microsoft.EntityFrameworkCore;

namespace TestPostGis.Models
{
    public class BEDBContext : DbContext
    {
        public BEDBContext(DbContextOptions<BEDBContext> options) : base(options)
        {

        }

        public DbSet<GeometryDAO> Geometries { get; set; }
    }
}
