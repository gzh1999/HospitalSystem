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
    public class DrugController : ApiController
    {
        DrugDAL dal = new DrugDAL();
        // GET: api/Drug
        public PageInfo Get(string DrugTypeId = null,string DrugCreateTime=null, string DrugName=null,int CurrentPage = 1,int PageSize=3)
        {
            var name = dal.DrugShow();

            if (DrugName != null)
            {
                name = name.Where(s => s.DrugName.Contains(DrugName)).ToList();
            }
            if (DrugCreateTime != null)
            {
                name = name.Where(s => s.DrugCreateTime.Contains( DrugCreateTime)).ToList();
            }
            if (DrugTypeId != null)
            {
                name = name.Where(s => s.DrugTypeId==Convert.ToInt32(DrugTypeId)).ToList();
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
            p.drugs = name.Skip(PageSize * (CurrentPage - 1)).Take(PageSize).ToList();
            p.CurrentPage = CurrentPage;
            return p;
        }

        // GET: api/Drug/5
        public Drug Get(int id)
        {
            return dal.DrugFill(id);
        }

        // POST: api/Drug
        public int Post([FromBody]Drug m)
        {
            return dal.DrugAdd(m);
        }

        // PUT: api/Drug/5
        [HttpPost]
        public int Put([FromBody]Drug m)
        {
            return dal.DrugUpt(m);
        }

        // DELETE: api/Drug/5    
        public void Delete(int id)
        {
        }
    }
}
