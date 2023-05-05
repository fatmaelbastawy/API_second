using context;
using domain;
using infastructure;
using qena.api.contracts;

namespace infrastructure
{
    public class ProductRepository : Repository<Product, long>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {

        }

        


        public Task<IEnumerable<Product>> FilterByAsync(string? filter = null, int? fromPrice = null, int? toPrice = null, bool? isAvailable = null, bool? hasDiscount = null, int? categoryId = null)
        {

            filter = filter?.ToLower();

            IEnumerable<Product> Products = _context.Productss

                .Where(a => filter == null || a.Name.ToLower().Contains(filter.ToLower()) )
                .Where(a => fromPrice == null || a.Price >= fromPrice)
                .Where(a => toPrice == null || a.Price <= toPrice)
                .Where(a => isAvailable == null || a.Available > 0)
                .Where(a => hasDiscount == null || a.Discound_persentage != null)
                .Where(a => categoryId == null || a.Categories.Any(b => b.ID == categoryId));
            return Task.FromResult(Products);
        }

       
    }
}