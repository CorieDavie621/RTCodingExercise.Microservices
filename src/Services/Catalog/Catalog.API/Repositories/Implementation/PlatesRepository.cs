using Catalog.API.Repositories.Interface;

namespace Catalog.API.Repositories.Implementation
{
    public class PlatesRepository : IPlatesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PlatesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<Plate>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
