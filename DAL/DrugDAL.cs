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
            string sql = "select * from Drug d join DrugType t on d.DrugTypeId=t.Id join Manufacturers m on d.ManufacturersId=m.Id ";
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
        //绑定生产厂家
        public List<Manufacturers> ManufacturersBandsel()
        {
            string sql = "select * from Manufacturers ";
            return db.GetToList<Manufacturers>(sql);
        }
        //添加生产厂家
        public int ManufacturersAdd(Manufacturers m)
        {
            string sql = string.Format("insert into Manufacturers values('{0}')", m.ManufacturersName);
            return db.ExecuteNonQuery(sql);
        }
        //添加药品
        public int DrugAdd(Drug m)
        {
            string sql = string.Format("insert into Drug values('{0}','{1} ','{2}','{3}','{4}','{5}','{6}','{7}')",
                m.DrugNumber, m.DrugName, m.DrugPrice, m.DrugSelling, m.ManufacturersId, m.DrugStatus, m.DrugCreateTime, m.DrugTypeId);
            return db.ExecuteNonQuery(sql);
        }
    }
}
