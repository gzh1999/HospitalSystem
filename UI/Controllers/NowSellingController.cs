using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using DAL;
using System.Web.Management;

namespace UI.Controllers
{
    public class NowSellingController : ApiController //原价调成现价
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/NowSelling
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NowSelling/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NowSelling
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NowSelling/5
        [HttpPost]
        public int Put([FromBody]Drug m)//原价调成现价
        {
            return dal.NowSelling(m);
        }

        // DELETE: api/NowSelling/5
        public void Delete(int id)
        {
        }
    }
}
