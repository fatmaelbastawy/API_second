using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class images
    {
        public long ID { get; set; }
        [MinLength(16), MaxLength(800)]
        public string Name { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }

        public images(string name, float length, float width, float height, Product product, Category category)
        {
            Name = name;
            Length = length;
            Width = width;
            Height = height;
            Product = product;
            Category = category;

        }

        private images() 
        { }
    }

}
