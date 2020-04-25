using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using DAL;

namespace UI.Controllers
{
    public class RepertoryController : ApiController
    {
        /// <summary>
        /// 库存表操作
        /// </summary>
        DrugDAL dal = new DrugDAL();
        // GET: api/Repertory
        public PageInfo Get(string AuditStatusId=null,string RepertoryTypeId=null,string RepertoryNumber=null, int CurrentPage = 1, int PageSize = 6)
        {
            var name = dal.RepertoryShow();
            //查询审核状态
            if (AuditStatusId != null)
            {
                name = name.Where(s => s.AuditStatusId == Convert.ToInt32(AuditStatusId)).ToList();
            }
            //查询入库
            if (RepertoryTypeId != null)
            {
                name = name.Where(s => s.RepertoryTypeId == Convert.ToInt32(RepertoryTypeId)).ToList();
            }
            //查询编号和供应商
            if (RepertoryNumber != null)
            {
                name = name.Where(s => s.RepertoryNumber.Contains(RepertoryNumber)).ToList();
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
            p.repertories = name.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }

        // GET: api/Repertory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Repertory
        public int  Post([FromBody]Repertory m)
        {
            return dal.RepertoryAdd(m);
        }

        // PUT: api/Repertory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Repertory/5
        public int Delete(int id)
        {
            return dal.RepertoryDel(id);
        }
    }
}
