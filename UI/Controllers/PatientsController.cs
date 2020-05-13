using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class PatientsController : Controller
    {
        // GET: Patient 患者显示+查询
        public ActionResult PatientsShow()
        {
            return View();
        }


        // GET: Patient/Create 新增患者
        public ActionResult PatientsAdd()
        {
            return View();
        }

        // GET: Patient/Edit/5  患者详情
        public ActionResult PatientsFind()
        {
            return View();
        }

        // POST: Patient/Edit/5 编辑患者
        public ActionResult PatientsUpdate()
        {
            return View();
        }
        public ActionResult Show()
        {
            return View();
        }
    }
}