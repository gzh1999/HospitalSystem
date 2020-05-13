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
    public class OutRepertoryXiangController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/OutRepertoryXiang
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OutRepertoryXiang/5
        public OutRepertory Get(int id)
        {
            return dal.OutRepertoryXiang(id);
        }

        // POST: api/OutRepertoryXiang
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OutRepertoryXiang/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OutRepertoryXiang/5
        public void Delete(int id)
        {
        }
    }
}
