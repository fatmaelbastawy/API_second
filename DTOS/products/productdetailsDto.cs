using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.products
{
    public class productDetailsDto
    {
        public productDetailsDto(long id, string name)
        {
            Name = name;
        }

        public productDetailsDto(int id, string? name, decimal price, string? description=null)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }
    }


}
