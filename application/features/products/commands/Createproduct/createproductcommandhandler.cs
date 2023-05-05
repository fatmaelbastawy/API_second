using domain;
using DTOS.products;
using MediatR;
using qena.api.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.commands.Createproduct
{
    public class Createproductcommandhandler : IRequestHandler<CreateproductCommand ,productMinimalDto>
    {
        private readonly IProductRepository _ProductRepository;

        public Createproductcommandhandler(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
       

        public async Task<productMinimalDto> Handle(CreateproductCommand request, CancellationToken cancellationToken)
        {

            var product = new Product(request.Name, request.Price);
            product = await _ProductRepository.CreateOnDbAsync(product);
            return new productMinimalDto() { Id = (int)product.Id, Name = product.Name };
        }
    }
}
