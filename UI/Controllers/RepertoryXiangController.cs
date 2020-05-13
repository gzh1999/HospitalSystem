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
    public class RepertoryXiangController : ApiController  //库存明细(入库明细)
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/RepertoryXiang
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RepertoryXiang/5
        public Repertory Get(int id)
        {
            return dal.RepertoryXiang(id);
        }

        // POST: api/RepertoryXiang
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RepertoryXiang/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RepertoryXiang/5
        public void Delete(int id)
        {
        }
    }
}
