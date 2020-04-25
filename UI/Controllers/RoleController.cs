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
    public class RoleController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/Role
        public IEnumerable<Role> Get()
        {
            return dal.RoleBandsel();
        }
    }
}
