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
    public class BandOfficeController : ApiController
    {
        SYDAL dal = new SYDAL();
        // GET: api/BandOffice
        public List<Office> Get()
        {
            return dal.BandOffice();
        }
    }
}
