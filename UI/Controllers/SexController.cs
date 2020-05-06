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
    public class SexController : ApiController
    {
        HCXDAL dal = new HCXDAL();
        // GET: api/Sex
        public IEnumerable<Sex> Get()
        {
            return dal.SexBand();
        }

    }
}
