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
    /// <summary>
    /// ZHC会员表操作
    /// </summary>
    public class MenberController : ApiController
    {
        ZHCDAL dal = new ZHCDAL();
        // GET: api/Stu
        public PageInfo Get(string name = "",string MenberTypeId="" ,int CurrentPage = 1, int PageSize = 5)
        {
            var list = dal.MenberShow();
            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(s => s.MenberName.Contains(name)).ToList();
            }
            if (MenberTypeId != "")
            {
                list = list.Where(s => s.MenberTypeId == MenberTypeId).ToList();
            }
            //实例化分页类
            var p = new PageInfo();
            //总记录数
            p.TotalCount = list.Count();
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
            p.menbers = list.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }


        // GET: api/Stu/5
        public Menber Get(int id)
        {
            return dal.MenberFill(id);
        }

        // POST: api/Stu
        public void Post([FromBody]string value)
        {
        }
        [HttpPost]
        // PUT: api/Stu/5
        public int Put([FromBody]Menber a)
        {
            return dal.MenberUpt(a);
        }

        // DELETE: api/Stu/5
        public void Delete(int id)
        {
        }
    }
}
