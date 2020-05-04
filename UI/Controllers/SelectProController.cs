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
    public class SelectProController : ApiController
    {
        SYDAL dal = new SYDAL();
        // GET: api/SelectPro
        public List<AddStaff> Get()
        {
            return dal.SelectPro();
        }
    }
}
