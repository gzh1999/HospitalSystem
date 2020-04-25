using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class RepertoryController : Controller
    {
        // GET: Repertory
        //库存表显示
        public ActionResult RepertoryShow()
        {
            return View();
        }
        //绑定审核状态
        public ActionResult AuditStatusBandsel()
        {
            return View();
        }
        //绑定入库类型
        public ActionResult RepertoryTypeBandsel()
        {
            return View();
        }
        //药品入库
        public ActionResult RepertoryAdd()
        {
            return View();
        }
        //绑定人员表
        public ActionResult RoleBandsel()
        {
            return View();
        }
        //绑定生产厂家
        public ActionResult ManufacturersBandsel()
        {
            return View();
        }
    }
}