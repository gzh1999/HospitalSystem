using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class DrugController : Controller
    {
        // GET: Drug
        //显示药品表
        public ActionResult DrugShow()
        {
            return View();
        }
        //添加药品
        public ActionResult DrugAdd()
        {
            return View();
        }
        //绑定药品分类
        public ActionResult DrugTypeBandsel()
        {
            return View();
        }
        //添加药品分类
        public ActionResult DrugTypeAdd()
        {
            return View();
        }
    }
}