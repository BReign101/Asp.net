using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inventories.Controllers
{
    public class SpringfieldGrocerController : ApiController
    {
        OrderItem[] Items = new OrderItem[]
        {
            new OrderItem {  }
         
        };

        public IEnumerable<OrderItem> GetAllProducts()
        {
            return Items;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var orderItem = Items.FirstOrDefault((p) => p.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return Ok(orderItem);
        }
    }
}
