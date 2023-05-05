using DTOS.products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.commands.Createproduct
{
    public class CreateproductCommand : IRequest<productMinimalDto>
    {
        public string Name { get; set; }
        public float Price { get; set; }








        public CreateproductCommand(string name, float price)
        {
            Name = name;
            Price = price;



        }
    }
}
