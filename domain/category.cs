using System.ComponentModel.DataAnnotations;

namespace domain
{
    public class Category
    {
        public int ID { get; set; }

        [MinLength(10), MaxLength(500)]

        public string Name { get; set; }

        private IList<Product> products;

        public IEnumerable<Product> Products
        {
            get
            {
                return products;
            }
        }

        public Category? Parent_Category { get; set; }

        private IList<Category> sub_Categories;
        public IEnumerable<Category> Sub_Categories { 
            get
            {
                return sub_Categories;

            } 
        }

        //public images Images { get; set; }

        public Category(string name,  Category? parentCategory=null)
        {
            Name = name;
            //Images = images;
            Parent_Category = parentCategory;
            products = new List<Product>();
            sub_Categories = new List<Category>();

        }

        public bool addsubcategory ( Category subcategory)
        {
            var category = sub_Categories.FirstOrDefault(a => a.Name == subcategory.Name);
            if(category==null)
            {

                sub_Categories.Add(subcategory);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addproduct(Product product)
        {
            var p_product = products.FirstOrDefault(a => a.Name == product.Name);
            if (p_product == null)
            {

                products.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        private Category ():this (null! ,null!)
        { }


    }
}