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
    public class PutController : ApiController
    {
        dal udal = new dal();
        // GET: api/Put
        public PageInfo Get(int CurrentPage = 1, int PageSize = 5)
        {
            var list = udal.SettingShow();
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
            p.Settings = list.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }

        // GET: api/Put/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Put
        public int Post([FromBody]Setting a)
        {
            return udal.SettingAdd(a);
        }

        // PUT: api/Put/5

        [HttpPost]
        public int Put([FromBody]Setting a)
        {
            return udal.SettingUpt(a);
        }

        // DELETE: api/Put/5
        public void Delete(int id)
        {
        }
    }
}
