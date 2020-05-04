using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UsearInfo

        public ActionResult Loginif() //登录
        {
            return View();
        }
        public ActionResult ForgetPwd(string zhang) //忘记密码
        {
            ViewBag.zh = zhang;
            return View();
        }
        public ActionResult Register() //注册账号
        {
            return View();
        }
        public ActionResult qwe()
        {
            return View();
        }
        /// <summary>
        /// 登录页面验证码
        /// </summary>
        /// <returns></returns>
        public int Indexyanz(string yan)
        {
            int res = 0;
            string cnum = Session["CheckCode"].ToString();
            if (yan.ToLower() == cnum.ToLower())
            {
                res = 1;
                return res;
            }
            else
            {
                return res;
            }
        }
        
    }
}