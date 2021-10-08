using los_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace los_api.Controllers
{
    public class ValuesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        [HttpPost]
        public void insertProduct(string productid)
        {
            using (losapiEntities a = new losapiEntities())
            {

            }
        }
        [HttpGet]
        public List<ProductDetail> getStock(string productid)
        {
            List<ProductDetail> datalist = new List<ProductDetail>();
            using (losapiEntities db= new losapiEntities())
            {
                var query = (from st in db.Stock
                             join pd in db.Product on st.ProductId equals pd.ID
                             where st.ProductId == productid
                             select new {stock =st ,product= pd }).ToList();
                            
                if(query != null)
                {
                    foreach (var q in query)
                    {
                        var data = new ProductDetail();
                        data.ProductID = q.stock.ProductId;
                        data.Productname = q.product.name;
                        data.imageUrl = q.product.imageUrl;
                        data.price = q.product.price;
                        data.amount = q.stock.amount;
                        datalist.Add(data);
                    }
                }
               
            }
          
            return datalist;
        }

    }
}
