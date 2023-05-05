using Microsoft.AspNetCore.Mvc;
using context;
using System.ComponentModel.DataAnnotations;
using domain;

using application.features.products.queries.get_all_products;
using MediatR;
using System;
using application.features.products.queries.get_product_details;
using DTOS.products;
using application.features.products.commands.Createproduct;
using application.features.products.commands.delete_product;
using application.features.products.commands.edit_product;

namespace qena.api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;
        private readonly IMediator _mediator;

        public ProductController(Context context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }



        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_mediator.Send(new FilterproductQuery()));
        }


        [HttpGet("{id}")]

        public async Task< IActionResult> GetAllProductDetails([FromRoute] int id)
        {
            return Ok(await _mediator.Send(new GetproductDetailsQuery(id)));
        }

        //[HttpGet("dd")]

        //public IActionResult GetAllProductDetails([FromBody] int id)
        //{
        //    return Ok(_mediator.Send(new GetproductDetailsQuery(id)));
        //}


        //[HttpPost("ss")]
        //public IActionResult CreateProduct([FromBody] productDetailsDto pro)
        //{
        //    Product product = new Product(pro.Name, (float)pro.Price); 
        //    _context.Productss.Add(product);

        //    _context.SaveChanges();
        //    return Ok(product);
        //}



        [HttpPost]
        public async Task<IActionResult> CreatepProduct([FromBody] CreateproductCommand CreateproductCommand)
        {

            return Ok(await _mediator.Send(CreateproductCommand));

        }



        [HttpDelete()]
        public async Task<IActionResult> DeleteCategory([FromBody] DeleteProductCommand DeleteProductCommand)
        {
            return Ok(await _mediator.Send(DeleteProductCommand));

        }

        [HttpPut()]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateProductCommand UpdateProductCommand)
        {
            return Ok(await _mediator.Send(UpdateProductCommand));
        }


        //[HttpPut("{id}")]

        //public IActionResult UpdateProduct(int id, [FromBody] productDetailsDto pro)
        //{
        //    var product = _context.Productss.FirstOrDefault(x => x.Id == id);

        //    if (product == null)
        //    {
        //        return NotFound("Not Found  Product");
        //    }
        //    else
        //    {

        //        product.Name = pro.Name;
        //        product.Price = (float)pro.Price;
        //        product.Description = pro.Description;

        //        _context.SaveChanges();

        //        return Ok("updated");
        //    }

        //}


        //[HttpDelete("{id}")]

        //public IActionResult DeleteProduct(int id)
        //{
        //    var product = _context.Productss.FirstOrDefault(x => x.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound("Not Found  Product in DB ");
        //    }
        //    else
        //    {
        //        _context.Productss.Remove(product);
        //        _context.SaveChanges();

        //        return Ok("Deleted");
        //    }
        //}


        
















        //private readonly Context context;

        //public ProductController(Context _context)
        //{
        //    context = _context;
        //}

        //// localhost:7063/api/Product/all
        //[HttpGet("all")]
        //public IActionResult GetAllProducts()
        //{
        //    try
        //    {
        //        return Ok(context.Productss);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("Sorry All Data Not Available");
        //    }

        //}
        //// localhost:7063/api/Product/4
        //[HttpGet("{id}")]
        //public IActionResult GetAllProductsbyID(int id)
        //{
        //    try
        //    {
        //        return Ok(context.Productss.Where(p => p.Id == id));
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("Sorry All Data Not Available");
        //    }

        //}

        //// localhost:7063//api/Product/8
        //[HttpGet("cat/{Cat_id}")]
        //public IActionResult GetAllProductsbyCategoryID(int Cat_id)
        //{
        //    try
        //    {
        //        return Ok(context.Catigoes.Where(p => p.ID == Cat_id).Select(p => p.Products));
        //    }
        //    catch (Exception )
        //    {
        //        return BadRequest("Sorry All Data Not Available");
        //    }

        //}


        //[HttpPost]
        //public IActionResult InsertProduct([FromBody] Insert_productDto insert_ProductDto)
        //{
        //    Product product = new Product("phone", 2595, 5);

        //    product.Name = insert_ProductDto.Name;
        //    product.Price = insert_ProductDto.Price;
        //    product.Available = insert_ProductDto.Available;

        //    context.Productss.Add(product);
        //    context.SaveChanges();

        //    return Ok(product);
        //}



        ////[HttpPut]
        ////public IActionResult UpdateProduct([FromBody] update_productDto update_productDto)
        ////{
        ////    Product product = new Product("iphone", 4500, 5);

        ////    product.ID = update_productDto.ID;
        ////    product.Name = update_productDto.Name;
        ////    product.Price = update_productDto.Price;

        ////    context.Update(product);
        ////    context.SaveChanges();

        ////    return Ok(product);
        ////}


        ////[HttpPost()]
        ////public IActionResult createproduct ([FromBody] Insert_productDto insert_ProductDto)
        ////{
        ////    try
        ////    {
        ////        Product Product = new Product(insert_ProductDto.Name, insert_ProductDto.Price, insert_ProductDto.Available)
        ////        {
        ////            //ID = insert_ProductDto.ID,

        ////            Discription = insert_ProductDto.Discription,



        ////        };

        ////        //Product Product = new Product()
        ////        //{
        ////        //    ID = insert_ProductDto.ID,

        ////        //    Discription = insert_ProductDto.Discription,
        ////        //    Name= insert_ProductDto.Name,
        ////        //    Price= insert_ProductDto.Price,
        ////        //    Available = insert_ProductDto.Available



        ////        //};

        ////        context.Productss.Add(Product);
        ////        context.SaveChanges();

        ////        return Ok(" insert done");
        ////    }
        ////    catch (Exception)
        ////    {
        ////        return BadRequest("try again");
        ////    }




        ////}



        //[HttpPut]
        //public IActionResult Updateproduct([FromBody] update_productDto update_productDto)
        //{
        //    try
        //    {
        //        Product product = context.Productss.Where(P => P.Id == update_productDto.ID).FirstOrDefault();

        //        product.Name = update_productDto.Name;
        //        product.Price = update_productDto.Price;
        //        product.Available = update_productDto.Available;




        //        context.SaveChanges();

        //        return Ok(" update done");
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("try again");
        //    }
        //}


        //[HttpDelete("{id}")]
        //public IActionResult deleteproduct([FromRoute] int id)
        //{
        //    try
        //    {
        //        Product product = context.Productss.Where(P => P.Id == id).FirstOrDefault();

        //        context.Productss.Remove(product);
        //        context.SaveChanges();

        //        return Ok(" delete done");
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("try again");
        //    }

        //}

        //public class Insert_productDto
        //{
        //    //public long ID { get; set; }

        //    [MinLength(10), MaxLength(500)]
        //    public string? Name { get; set; }

        //    //[MinLength(10), MaxLength(500)]
        //    //public string? Discription { get; set; }

        //    public float Price { get; set; }

        //    public int Available { get; set; }
        //}



        //public class update_productDto
        //{
        //    public long ID { get; set; }


        //    public string? Name { get; set; }

        //    public float Price { get; set; }

        //    public int Available { get; set; }
        //}





    }
}
