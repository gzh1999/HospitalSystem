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
    public class DrugRepertoryController : ApiController
    {
        /// <summary>
        /// 药品入库信息
        /// </summary>
        DrugDAL dal = new DrugDAL();
        // GET: api/DrugRepertory
        public IEnumerable<DrugRepertory> Get()
        {
            return dal.DrugRepertoryShow();
        }

        // GET: api/DrugRepertory/5
        public Repertory Get(int id)
        {
            return dal.RepertoryFill(id);
        }

        // POST: api/DrugRepertory
        public int Post([FromBody]DrugRepertory m)
        {
            return dal.DrugRepertoryAdd(m);
        }

        // PUT: api/DrugRepertory/5
        [HttpPost]
        //借用修改审核状态为不通过，哈哈
        public int Put([FromBody]Repertory m)
        {
            return dal.AuditStatusUptBTG(m);
        }

        // DELETE: api/DrugRepertory/5
        [HttpPost]
        public int  Delete(int id)
        {
            return dal.DrugRepertoryDel(id);
        }
    }
}
