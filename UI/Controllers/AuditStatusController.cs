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
    public class AuditStatusController : ApiController
    {
        /// <summary>
        /// 绑定审核状态
        /// </summary>
        DrugDAL dal = new DrugDAL();
        // GET: api/AuditStatus
        public IEnumerable<AuditStatus> Get()
        {
            return dal.AuditStatusBandsel();
        }
    }
}
