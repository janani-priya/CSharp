using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
      Product[] products = new Product[]
      {
          new Product{id=1, name="books", catergory= "story book", price=50},
          new Product{id=2, name="toys", catergory="doll", price=50},
          new Product{id=3, name="movies", catergory="rental", price=50},
      };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


        public IHttpActionResult GetProductWithId(int id)
        {
            var prod = products.FirstOrDefault(p => p.id == id);
            if (prod == null)
            {
                return NotFound();
            }

            return Ok(prod);

        }
    }
}
