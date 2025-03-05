namespace Catalog.API.Repositories.Interface
{
    public interface IPlatesRepository
    {
        Task<IEnumerable<Plate>> Get();
    }
}
