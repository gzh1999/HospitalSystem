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
    public class UptStatussoffController : ApiController
    {
        SYDAL dal = new SYDAL();
        // PUT: api/Status/5
        [HttpPost]
        public int Put([FromBody]Office o)
        {
            return dal.UptStatussoff(o);
        }
    }
}
