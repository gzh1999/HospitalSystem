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
    public class UptStatussroleController : ApiController
    {
        SYDAL dal = new SYDAL();
        // PUT: api/Status/5
        [HttpPost]
        public int Put([FromBody]Role r)
        {
            return dal.UptStatussrole(r);
        }
    }
}
