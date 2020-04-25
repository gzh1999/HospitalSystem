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
    public class RepertoryTypeController : ApiController
    {
        /// <summary>
        /// 绑定入库类型
        /// </summary>
        DrugDAL dal = new DrugDAL();
        // GET: api/RepertoryType
        public IEnumerable<RepertoryType> Get()
        {
            return dal.RepertoryTypeBandsel();
        }

    }
}
