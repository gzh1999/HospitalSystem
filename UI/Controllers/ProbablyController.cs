using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ProbablyController : Controller
    {
        /// <summary>
        /// 概况or工作台
        /// </summary>
        /// <returns></returns>
        // GET: Probably
        public ActionResult ProbablyShow()
        {
            return View();
        }
        //工作台
        public ActionResult WorkBench()
        {
            return View();
        }
        //接诊
        public ActionResult JieZhen()
        {
            return View();
        }
    }
}