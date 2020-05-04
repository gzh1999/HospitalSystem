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
    public class SelectCityController : ApiController
    {
        SYDAL dal = new SYDAL();
        // GET: api/SelectCity
        public List<AddStaff> Get(int proid)
        {
            return dal.SelectCity(proid);
        }
    }
}
