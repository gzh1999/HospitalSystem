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
    public class OutRepertoryAddStatusController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/OutRepertoryAddStatus
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OutRepertoryAddStatus/5
        public OutRepertory Get(int id)    //借用一下(出库详情审核通过)
        {
            return dal.OutRepertoryFill(id);
        }

        // POST: api/OutRepertoryAddStatus
        public int Post([FromBody]OutRepertory m)//新增入库(提交审核)
        {
            return dal.OutRepertoryAddStatus(m);
        }

        // PUT: api/OutRepertoryAddStatus/5
        [HttpPost]
        public int Put([FromBody]OutRepertory m) //借用一下(修改出库审核未通过)
        {
            return dal.OutAuditStatusUptBTG(m);
        }

        // DELETE: api/OutRepertoryAddStatus/5
        public void Delete(int id)
        {
        }
    }
}
