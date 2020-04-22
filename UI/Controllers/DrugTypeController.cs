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
    public class DrugTypeController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/DrugType
        public IEnumerable<DrugType> Get()
        {
            return dal.DrugTypeBandsel();
        }


        // POST: api/DrugType
        public int Post([FromBody]DrugType m)
        {
            return dal.DrugTypeAdd(m);
        }

    }
}
