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
    public class PatientsController : ApiController
    {
        // GET: api/Patients
        HCXDAL dal = new HCXDAL();
        // GET: api/Patients  患者显示+查询
        public PageInfo Get(string name = "", string vip = "", string time = "", int index = 1, int PageSize = 5)
        {
            var list = dal.PatientShow(name, vip, time);
            //实例化PageInfo
            PageInfo p = new PageInfo();
            p.TotalCount = list.Count();//总记录数
            p.CurrentPage = index;
            //判断总页数
            if (p.TotalCount % PageSize == 0)
            {
                p.TotalPage = p.TotalCount / PageSize;//总页数
            }
            else
            {
                p.TotalPage = (p.TotalCount / PageSize) + 1;//总页数
            }
            //判断当前页
            if (index < 1) //当前页小于1时就显示第一页
            {
                index = 1;
            }
            else if (index > p.TotalPage)  //当前页大于总页数时就显示最大页数
            {
                index = p.TotalPage;
            }
            p.patients = list.Skip(PageSize * (index - 1)).Take(PageSize).ToList();//分页的核心代码
            return p;
        }

        // GET: api/Patients/5  患者详情
        public Patient Get(int id)
        {
            return dal.Find(id);
        }

        // POST: api/Patients  患者添加
        public int Post([FromBody]Patient m)
        {
            return dal.Add(m);
        }

        // PUT: api/Patients/5  患者编辑
        [HttpPost]
        public int Put([FromBody]Patient m)
        {
            return dal.Update(m);
        }

        // DELETE: api/Patients/5  删除患者
        [HttpPost]
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}
