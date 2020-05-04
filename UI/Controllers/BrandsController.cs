using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using DAL;

namespace UI.Controllers
{
    public class BrandsController : ApiController
    {
        // GET: api/Brands
        dal udal = new dal();
        public IEnumerable<Setting> Get()
        {
            return udal.Brands();
        }


        // GET: api/Brands/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Brands
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Brands/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Brands/5
        public void Delete(int id)
        {
        }
    }
}
