using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        //员工
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Fill()
        {
            return View();
        }
        public ActionResult Upt()
        {
            return View();
        }
        public ActionResult Del()
        {
            return View();
        }


        //科室
        public ActionResult Showoff()
        {
            return View();
        }
        public ActionResult Addoff()
        {
            return View();
        }
        public ActionResult Filloff()
        {
            return View();
        }
        public ActionResult Uptoff()
        {
            return View();
        }
        public ActionResult Deloff()
        {
            return View();
        }


        //角色
        public ActionResult Showrole()
        {
            return View();
        }
        public ActionResult Addrole()
        {
            return View();
        }
        public ActionResult Fillrole()
        {
            return View();
        }
        public ActionResult Uptrole()
        {
            return View();
        }
        public ActionResult Delrole()
        {
            return View();
        }
    }
}