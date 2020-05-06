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
    public class OutDrugRepertoryController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/OutDrugRepertory
        /// <summary>
        /// 药品出库到出库信息表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OutDrugRepertory> Get()
        {
            return dal.OutDrugRepertoryShow();
        }

        // GET: api/OutDrugRepertory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OutDrugRepertory
        public int Post([FromBody]OutDrugRepertory m)
        {
            return dal.OutDrugRepertoryAdd(m);
        }

        // PUT: api/OutDrugRepertory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OutDrugRepertory/5
        [HttpPost]
        public int Delete(int id)   //删除出库药品信息
        {
            return dal.OutDrugRepertoryDel(id);
        }
    }
}
