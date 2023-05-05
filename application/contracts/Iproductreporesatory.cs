using application.contracts;
using domain;

namespace qena.api.contracts
{

    public interface IProductRepository : IRepository<Product, long>
    {
        Task<IEnumerable<Product>> FilterByAsync(string? filter = null, int? fromPrice = null, int? toPrice = null, bool? isAvailable = null, bool? hasDiscount = null, int? categoryId = null);
    }

}
