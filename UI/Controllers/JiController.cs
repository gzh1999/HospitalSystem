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
    public class JiController : ApiController
    {
        dal udal = new dal();
        // GET: api/Stu
        public PageInfor Get(string name = "", string pricemin = "", string pricemax = "", int type = 0, string band = "", int CurrentPage = 1, int PageSize = 5)
        {
            var list = udal.MenbShow();
            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(s => s.MenberName.Contains(name)).ToList();
            }
            if (pricemin != "" && pricemax != "")
            {
                list = list.Where(s => s.MenberCard >= Convert.ToInt32(pricemin) && s.MenberCard <= Convert.ToInt32(pricemax)).ToList();
            }
            if (!string.IsNullOrEmpty(band))
            {
                list = list.Where(s => s.MenberPhone.Contains(band)).ToList();
            }
            if (type != 0)
            {
                list = list.Where(s => s.Integral == type).ToList();
            }
            //实例化分页类
            var p = new PageInfor();
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
            p.shopModels = list.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }

        // GET: api/Ji/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ji
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ji/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ji/5
        public void Delete(int id)
        {
        }
    }
}
