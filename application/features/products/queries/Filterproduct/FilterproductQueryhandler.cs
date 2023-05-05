using DTOS.products;
using MediatR;
using qena.api.contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.queries.get_all_products
{
    public class FilterproductQueryHandler : IRequestHandler<FilterproductQuery, IEnumerable<productMinimalDto>>
    {
        private readonly IProductRepository _ProductRepository;

        public FilterproductQueryHandler(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        

        public async Task<IEnumerable<productMinimalDto>> Handle(FilterproductQuery request, CancellationToken cancellationToken)
        {
            return (await _ProductRepository.FilterByAsync(request.Filter)) /*calling FilterByAsync*/
                .Select(a => new productMinimalDto { Id = (int)a.Id, Name = a.Name });  /*Mapping*/
        }
    }
}
