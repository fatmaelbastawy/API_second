using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Product
    {
        public long Id { get; set; }

        [MinLength(10) , MaxLength(500)]
        public string? Name { get; set; }

        [MinLength(10), MaxLength(500)]
        public string? Discription { get; set; }

        public float Price { get; set; }

        [Range(0,100)]
        public byte? Discound_persentage { get; set; }

        public int? Available { get; set; }


        private IList<Category> categories;
        public IEnumerable<Category> Categories
        {
            get
            {
                return categories;
            }
        }

        private IList<images> images;
        public string? Description;

        public IEnumerable<images> Images {
            get
            {
                return images;

            }
        }





        public Product()
        { }


        public Product( string name, float price, int available, byte? discound_persentage=null, string? discription=null)
        {
            Name = name;
            Price = price;
            Available = available;
            Discound_persentage = discound_persentage;
            Discription = discription;
            categories = new List<Category>();
            images = new List<images>();


        }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public bool addcategory(Category itemcategory)
        {
            var c_category = categories.FirstOrDefault(a => a.Name == itemcategory.Name);
            if (c_category == null)
            {

                categories.Add(itemcategory);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addimage(images image)
        {
            var i_image = images.FirstOrDefault(a => a.Name == image.Name);
            if (i_image == null)
            {

                images.Add(image);
                return true;
            }
            else
            {
                return false;
            }
        }

       



        //public IEnumerable<order_details> Order_Details { get; set; }

        //public IEnumerable<Order> Orders { get; set; }
    }
}
