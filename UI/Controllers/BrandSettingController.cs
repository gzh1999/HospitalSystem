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
    public class BrandSettingController : ApiController
    {
        ZHCDAL dal = new ZHCDAL();
        // GET: api/BrandSetting
        public IEnumerable<Setting> Get()
        {
            return dal.BrandSetting();
        }

        // GET: api/BrandSetting/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BrandSetting
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BrandSetting/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BrandSetting/5
        public void Delete(int id)
        {
        }
    }
}
