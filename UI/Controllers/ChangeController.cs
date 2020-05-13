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
    public class ChangeController : ApiController
    {
        ZHCDAL dal = new ZHCDAL();
        // PUT: api/change/5
        //充值
        [HttpGet]
        public int Puts(int id)
        {
            return dal.change(id);
        }

        [HttpGet]
        public int Putes(int id = 0, decimal pays = 0)
        {
            return dal.chenge(pays, id);
        }
        //赠送
        [HttpGet]
        public int Putsss(int id)
        {
            return dal.change(id);
        }

        [HttpGet]
        public int Putesss(int id = 0, decimal Drawbacks = 0)
        {
            return dal.chenge(Drawbacks, id);
        }
        //退款
        [HttpGet]
        public int Puttui(int id)
        {
            return dal.changetui(id);
        }
        [HttpGet]
        public int PutTui1(int id = 0, decimal tui = 0)
        {
            return dal.chengtui1(tui, id);
        }
        //增加积分
        [HttpGet]
        public int Putjizeng(int id)
        {
            return dal.Integral1(id);
        }
        [HttpGet]
        public int Putjizeng1(int id = 0, decimal tui = 0)
        {
            return dal.Integral(tui, id);
        }
        //扣减积分
        [HttpGet]
        public int PutjiKou(int id)
        {
            return dal.Integraljian1(id);
        }
        [HttpGet]
        public int PutjiKou1(int id = 0, decimal tui = 0)
        {
            return dal.Integraljian(tui, id);
        }
        //积分清零
        [HttpGet]
        public int Putling(int id)
        {
            return dal.Integralling(id);
        }
    }
}
