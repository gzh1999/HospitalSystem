using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
    public class DrugDAL
    {
        //实例化dbhelp
        DBHelper db = new DBHelper();
        //显示药品表
        public List<Drug> DrugShow()
        {
            string sql = "select * from Drug ";
            return db.GetToList<Drug>(sql);
        }
        //绑定药品分类
        public List<DrugType> DrugTypeBandsel()
        {
            string sql = "select * from DrugType ";
            return db.GetToList<DrugType>(sql);
        }
        //添加药品分类
        public int DrugTypeAdd(DrugType m)
        {
            string sql = string.Format("insert into DrugType values('{0}')",m.DrugTypeName);
            return db.ExecuteNonQuery(sql);
        }

        //添加药品
        //public int DrugAdd(Drug m)
        //{ 
        //    string sql=string.Format("")
        //}
    }
}
