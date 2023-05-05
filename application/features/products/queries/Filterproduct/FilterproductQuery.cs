using DTOS.products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.queries.get_all_products
{
    public class FilterproductQuery : IRequest<IEnumerable<productMinimalDto>>
    {
        public string? Filter { get; set; }
    }
}
