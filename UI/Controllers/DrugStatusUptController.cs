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
