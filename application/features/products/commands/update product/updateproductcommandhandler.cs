using MediatR;
using qena.api.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.commands.edit_product
{
    public class UpdateproductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _ProductRepository;

        public UpdateproductCommandHandler(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }


        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _ProductRepository.GetByIdAsync(request.id);
            product.Name = request.Name;
            return await _ProductRepository.UpdateAsync(product);
        }
    }
}

