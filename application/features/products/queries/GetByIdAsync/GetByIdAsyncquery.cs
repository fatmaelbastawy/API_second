using DTOS.products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.queries.get_product_details
{
    public class GetproductDetailsQuery : IRequest<productDetailsDto>

    {
        public GetproductDetailsQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
