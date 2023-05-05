using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.commands.edit_product
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public int id { get; set; }
        public string? Name { get; set; }

    }
}
