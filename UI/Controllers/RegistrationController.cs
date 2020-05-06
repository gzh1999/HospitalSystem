using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        // GET: Patient 挂号显示+查询
        public ActionResult RegistrationShow()
        {
            return View();
        }


        // GET: Patient/Create 新增挂号
        public ActionResult RegistrationAdd()
        {
            return View();
        }

        // GET: Patient/Edit/5  挂号详情
        public ActionResult RegistrationFind()
        {
            return View();
        }

        // POST: Patient/Edit/5 编辑挂号
        public ActionResult RegistrationUpdate()
        {
            return View();
        }
    }
}