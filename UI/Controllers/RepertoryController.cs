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
        //药品入库信息表
        public ActionResult DrugRepertoryAdd()
        {
            return View();
        }
        //显示药品入库信息
        public ActionResult DrugRepertoryShow()
        {
            return View();
        }
        ////删除药品入库信息
        public ActionResult DrugRepertoryDel()
        {
            return View();
        }
        //删除入库信息
        public ActionResult RepertoryDel()
        {
            return View();
        }
        ////入库详情审核通过
        public ActionResult RepertoryFill1()
        {
            return View();
        }
        ////入库详情审核提交未通过
        public ActionResult RepertoryFill2()
        {
            return View();
        }
        ////入库详情审核编辑
        public ActionResult RepertoryFill3()
        {
            return View();
        }
        //修改审核状态为通过
        public ActionResult AuditStatusUptTG()
        {
            return View();
        }
        //修改审核状态未通过
        public ActionResult AuditStatusUptBTG()
        {
            return View();
        }
        //出库信息
        public ActionResult OutRepertoryShow()
        {
            return View();
        }
        //药品添加到出库信息
        public ActionResult OutDrugRepertoryAdd()
        {
            return View();
        }
        //新增出库(直接提交)
        public ActionResult OutRepertoryAdd()
        {
            return View();
        }
        //显示药品出库信息
        public ActionResult OutDrugRepertoryShow()
        {
            return View();
        }
        //删除药品信息表
        public ActionResult OutDrugRepertoryDel()
        {
            return View();
        }
    }
}