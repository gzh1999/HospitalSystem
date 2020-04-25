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

        PageInfo p=new PageInfo();
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
            string sql = string.Format("insert into Drug values('{0}','{1} ','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                m.DrugNumber, m.DrugName, m.DrugPrice, m.DrugSelling, m.ManufacturersId, m.DrugStatus, m.DrugCreateTime, m.DrugTypeId,m.Specification,m.InventoryUpperLimit,m.InventoryLowerLimit,m.DrugContent);
            return db.ExecuteNonQuery(sql);
        }
        //反填药品
        public Drug DrugFill(int id)
        {
            string sql = "select * from Drug d join DrugType t on d.DrugTypeId=t.Id join Manufacturers m on d.ManufacturersId=m.Id where d.Id= "+id;

            return db.GetToList<Drug>(sql)[0];
        }
        //编辑药品
        public int DrugUpt(Drug m)
        {
            string sql = string.Format("update Drug set DrugNumber='{0}',DrugName='{1} ',DrugPrice='{2}',DrugSelling='{3}',ManufacturersId='{4}',DrugStatus='{5}',DrugCreateTime='{6}',DrugTypeId='{7}',Specification='{8}',InventoryUpperLimit='{9}',InventoryLowerLimit='{10}',DrugContent='{11}' where Id='{12}'",
                m.DrugNumber, m.DrugName, m.DrugPrice, m.DrugSelling, m.ManufacturersId, m.DrugStatus, m.DrugCreateTime, m.DrugTypeId, m.Specification, m.InventoryUpperLimit, m.InventoryLowerLimit, m.DrugContent,m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //停用or启用药品状态
        public int DrugStatusUpt(Drug m)
        {
            string sql = string.Format("update Drug set DrugStatus=DrugStatus-1 where Id='{0}'",m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //库存表显示
        public List<Repertory> RepertoryShow()
        {
            string sql = "select * from Repertory r join RepertoryType t on r.RepertoryTypeId = t.Id join Manufacturers m on r.ManufacturersId=m.Id join Role e on r.RoleId = e.Id join AuditStatus a on r.AuditStatusId = a.Id";
            return db.GetToList<Repertory>(sql);
        }
        //绑定审核状态表
        public List<AuditStatus> AuditStatusBandsel()
        {
            string sql = "select * from AuditStatus ";
            return db.GetToList<AuditStatus>(sql);
        }
        //绑定入库类型
        public List<RepertoryType> RepertoryTypeBandsel()
        {
            string sql = "select * from RepertoryType ";
            return db.GetToList<RepertoryType>(sql);
        }
        //新增入库
        public int RepertoryAdd(Repertory m)
        {
            string sql = string.Format("insert into Repertory values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                m.RepertoryNumber, m.RepertoryTypeId, m.ManufacturersId, m.RoleId, m.AmountOfPurchase, m.RepertoryTime, m.MakeTime=DateTime.Now, m.AuditStatusId, m.DrugId,m.Remark);
            return db.ExecuteNonQuery(sql);
        }
        //删除入库信息
        public int RepertoryDel(int id)
        {
            string sql = "select * from Repertory where Id in ("+id+")";
            return db.ExecuteNonQuery(sql);
        }
        //绑定角色表
        public List<Role> RoleBandsel()
        {
            string sql = "select * from Role ";
            return db.GetToList<Role>(sql);
        }
    }
}
