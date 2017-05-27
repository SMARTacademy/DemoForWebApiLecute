using DemoForWebApiLecute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoForWebApiLecute.Controllers
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
        public void Post(string productId, double megapixel)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //public IEnumerable<Product> GetAllProduts() {
        //    return new List<Product>() {
        //        new Product{
        //            Id = 1,
        //            Name = "Prod 1",
        //            Description = "Prod 1 description"
        //        },
        //        new Product{
        //            Id = 2,
        //            Name = "Prod 2",
        //            Description = "Prod 2 description" },
        //        new Product{
        //            Id = 3,
        //            Name = "Prod 3",
        //            Description = "Prod 3 description" },
        //    };
        //}

        //public object GetTest()
        //{
        //    return new
        //    {
        //        Name = "Alice",
        //        Age = 23,
        //        Pets = new List<string> { "Fido", "Polly", "Spot" }
        //    };
        //}
    }
}
