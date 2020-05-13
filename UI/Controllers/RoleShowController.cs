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
    public class RoleShowController : ApiController
    {
        SYDAL dal = new SYDAL();
        // GET: api/Hospital
        public PageInfo Get(string RoleName = "", int CurrentPage = 1, int PageSize = 2)
        {
            var list = dal.Showrole();
            if (!string.IsNullOrEmpty(RoleName))
            {
                list = list.Where(s => s.RoleName.Contains(RoleName)).ToList();
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
            p.roles = list.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }



        // GET: api/Role/5
        public Role Get(int id)
        {
            return dal.Fillrole(id);
        }

        // POST: api/Role
        public int Post([FromBody]Role r)
        {
            return dal.Addrole(r);
        }

        // PUT: api/Role/5
        [HttpPost]
        public int Put([FromBody]Role r)
        {
            return dal.Uptrole(r);
        }

        // DELETE: api/Role/5
        [HttpPost]
        public int Delete(string id)
        {
            return dal.Delrole(id);
        }
    }
}
