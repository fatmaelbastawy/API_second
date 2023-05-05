using DTOS.products;
using MediatR;
using qena.api.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.queries.get_product_details
{

    public class GetproductDetailsQueryHandler : IRequestHandler<GetproductDetailsQuery,productDetailsDto>
    {
        private readonly IProductRepository _ProductRepository;

        public GetproductDetailsQueryHandler(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        
        public async Task<productDetailsDto> Handle(GetproductDetailsQuery request, CancellationToken cancellationToken)
        {
            var category = await _ProductRepository.GetByIdAsync(request.Id); /*calling*/

            return new productDetailsDto(category.Id, category.Name);  /*mapping*/
        }
    }

}
