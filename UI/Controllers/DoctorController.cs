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
    public class DoctorController : ApiController
    {
        HCXDAL dal = new HCXDAL();
        // GET: api/Doctor
        //绑定医生
        public IEnumerable<AddStaff> Get()
        {
            return dal.AddStaffShow();
        }

    }
}
