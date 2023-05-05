using MediatR;
using qena.api.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.commands.delete_product
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _ProductRepository;

        public DeleteProductCommandHandler(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
       

        public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return _ProductRepository.DeleteAsync(request.Id);
        }
    }
}
