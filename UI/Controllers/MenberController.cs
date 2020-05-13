using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class MenberController : Controller
    {
        /// <summary>
        /// 张海超会员
        /// </summary>
        /// <returns></returns>
        // GET: Menber
        // GET: Stu
        //会员列表
        public ActionResult MenberShow()
        {
            return View();
        }
        //会员设置
        public ActionResult SettingShow()
        {
            return View();
        }
        //储值管理
        public ActionResult MenbeShow()
        {
            return View();
        }
        //积分管理
        public ActionResult MenbShow()
        {
            return View();
        }
        //会员添加
        public ActionResult SettingAdd()
        {
            return View();
        }
        public ActionResult SettingUpt()
        {
            return View();
        }
        public ActionResult change()
        {
            return View();
        }
    }
}