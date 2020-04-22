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
    public class ManufacturersController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/Manufacturers
        public IEnumerable<Manufacturers> Get()
        {
            return dal.ManufacturersBandsel();
        }

        // POST: api/Manufacturers
        public int Post([FromBody]Manufacturers m)
        {
            return dal.ManufacturersAdd(m);
        }

    }
}
