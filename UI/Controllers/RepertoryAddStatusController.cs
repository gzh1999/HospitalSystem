using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DataModel;

namespace UI.Controllers
{
    public class RepertoryAddStatusController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/RepertoryAddStatus
        public IEnumerable<OutRepertoryType> Get()   //借用绑定出库类型表
        {
            return dal.OutRepertoryTypeBandsel();
        }

        // GET: api/RepertoryAddStatus/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RepertoryAddStatus
        public int Post([FromBody]Repertory m)
        {
            return dal.RepertoryAddStatus(m);
        }

        // PUT: api/RepertoryAddStatus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RepertoryAddStatus/5
        public void Delete(int id)
        {
        }
    }
}
