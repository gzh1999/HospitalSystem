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
    public class DrugController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/Drug
        public IEnumerable<Drug> Get()
        {
            return dal.DrugShow();
        }

        // GET: api/Drug/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Drug
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Drug/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Drug/5
        public void Delete(int id)
        {
        }
    }
}
