using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using DAL;
using System.Web.UI;

namespace UI.Controllers
{
    public class OutRepertoryController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/OutRepertory
        /// <summary>
        /// 出库信息
        /// </summary>
        /// <returns></returns>
        public PageInfo Get(string AuditStatusId = null, string OutRepertoryTypeId = null, string OutRepertoryNumber = null, int CurrentPage = 1, int PageSize = 6)
        {
            var name= dal.OutRepertoryShow();

            //查询审核状态
            if (AuditStatusId != null)
            {
                name = name.Where(s => s.AuditStatusId == Convert.ToInt32(AuditStatusId)).ToList();
            }
            //查询入库
            if (OutRepertoryTypeId != null)
            {
                name = name.Where(s => s.OutRepertoryTypeId == Convert.ToInt32(OutRepertoryTypeId)).ToList();
            }
            //查询编号和供应商
            if (OutRepertoryNumber != null)
            {
                name = name.Where(s => s.OutRepertoryNumber.Contains(OutRepertoryNumber)).ToList();
            }

            //实例化分页类
            var p = new PageInfo();
            //总记录数
            p.TotalCount = name.Count();
            //计算总页数
            if (p.TotalCount == 0)
            {
                p.TotalPage = 1;
            }
            else if (p.TotalCount % PageSize == 0)
            {
                p.TotalPage = p.TotalCount / PageSize;
            }
            else
            {
                p.TotalPage = (p.TotalCount / PageSize) + 1;
            }
            //纠正当前页不正确的值
            if (CurrentPage < 1)
            {
                CurrentPage = 1;
            }
            if (CurrentPage > p.TotalPage)
            {
                CurrentPage = p.TotalPage;
            }
            p.outRepertories = name.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }

        // GET: api/OutRepertory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OutRepertory   ////新增出库(直接提交)
        public int Post([FromBody]OutRepertory m)
        {
            return dal.OutRepertoryAdd(m);
        }

        // PUT: api/OutRepertory/5
        [HttpPost]
        public int Put([FromBody]OutRepertory m)   //借用一下(修改出库审核通过)
        {
            return dal.OutAuditStatusUptTG(m);
        }

        // DELETE: api/OutRepertory/5
        [HttpPost]
        public int Delete(int id)
        {
            return dal.OutRepertoryDel(id);
        }
    }
}
