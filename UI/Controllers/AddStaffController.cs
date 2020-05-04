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
    public class AddStaffController : ApiController
    {
        /// <summary>
        /// 员工表显示
        /// </summary>
        /// <returns></returns>
        SYDAL dal = new SYDAL();
        // GET: api/AddStaff
        public PageInfo Get(string StaffName = "", string OfficeId = "", int CurrentPage = 1, int PageSize = 2)
        {
            var list = dal.Show();
            if (!string.IsNullOrEmpty(StaffName))
            {
                list = list.Where(s => s.StaffName.Contains(StaffName)).ToList();
            }
            if (!string.IsNullOrEmpty(OfficeId))
            {
                list = list.Where(s => s.OfficeId == Convert.ToInt32(OfficeId)).ToList();
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
            p.addStaffs = list.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }


        // GET: api/AddStaff/5
        public AddStaff Get(int id)
        {
            return dal.Fill(id);
        }

        // POST: api/AddStaff
        public int Post([FromBody]AddStaff s)
        {
            return dal.Add(s);
        }

        // PUT: api/AddStaff/5
        [HttpPost]
        public int Put([FromBody]AddStaff s)
        {
            return dal.Upt(s);
        }

        // DELETE: api/AddStaff/5
        [HttpPost]
        public int Delete(int id)
        {
            return dal.Del(id);
        }
    }
}
