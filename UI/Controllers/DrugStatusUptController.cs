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
    public class DrugStatusUptController : ApiController
    {
        /// <summary>
        /// 药品状态操作
        /// </summary>
        DrugDAL dal = new DrugDAL();

        // GET: api/DrugRepertory/5
        public Drug Get(int id)   //借用一下(药品调价的反填)
        {
            return dal.DrugadJustPriceFill(id);
        }

        // POST: api/DrugStatusUpt
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DrugStatusUpt/5
        [HttpPost]
        public int Put([FromBody]Drug m)
        {
            return dal.DrugStatusUpt(m);
        }
    }
}
