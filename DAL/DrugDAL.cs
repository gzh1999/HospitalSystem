using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        string connstr = "Data Source=.;Initial Catalog=Hospitalystem;Integrated Security=True";

        PageInfo p = new PageInfo();
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
            string sql = string.Format("insert into DrugType values('{0}')", m.DrugTypeName);
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
            string sql = string.Format("insert into Drug values('{0}','{1} ','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                m.DrugNumber, m.DrugName, m.DrugPrice, m.DrugSelling, m.ManufacturersId, m.DrugStatus, m.DrugCreateTime, m.DrugTypeId, m.Specification, m.InventoryUpperLimit, m.InventoryLowerLimit, m.DrugContent, m.DrugCount);
            return db.ExecuteNonQuery(sql);
        }
        //反填药品
        public Drug DrugFill(int id)
        {
            string sql = "select * from Drug d join DrugType t on d.DrugTypeId=t.Id join Manufacturers m on d.ManufacturersId=m.Id where d.Id= " + id;

            return db.GetToList<Drug>(sql)[0];
        }
        //编辑药品
        public int DrugUpt(Drug m)
        {
            string sql = string.Format("update Drug set DrugNumber='{0}',DrugName='{1} ',DrugPrice='{2}',DrugSelling='{3}',ManufacturersId='{4}',DrugStatus='{5}',DrugCreateTime='{6}',DrugTypeId='{7}',Specification='{8}',InventoryUpperLimit='{9}',InventoryLowerLimit='{10}',DrugContent='{11}',DrugCount='{12}' where Id='{13}'",
                m.DrugNumber, m.DrugName, m.DrugPrice, m.DrugSelling, m.ManufacturersId, m.DrugStatus, m.DrugCreateTime, m.DrugTypeId, m.Specification, m.InventoryUpperLimit, m.InventoryLowerLimit, m.DrugContent, m.DrugCount, m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //停用or启用药品状态
        public int DrugStatusUpt(Drug m)
        {
            string sql = string.Format("update Drug set DrugStatus=DrugStatus-1 where Id='{0}'", m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //库存表显示
        public List<Repertory> RepertoryShow()
        {
            string sql = "select * from Repertory r join RepertoryType t on r.RepertoryTypeId = t.Id join Manufacturers m on r.ManufacturersId=m.Id join Role e on r.RoleId = e.Id join AuditStatus a on r.AuditStatusId = a.Id join DrugRepertory d on r.DrugRepertoryId=d.Id join Drug g on g.Id = d.DrugId";

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
        //新增入库(直接提交)
        public int RepertoryAdd(Repertory m)
        {
            string sql = string.Format("exec Repertory_Add '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'",
                m.RepertoryNumber, m.RepertoryTypeId, m.ManufacturersId, m.RoleId, m.RepertoryTime, m.MakeTime = DateTime.Now, m.AuditStatusId = 1, m.DrugRepertoryId, m.Remark);
            return db.ExecuteNonQuery(sql);
        }
        //新增入库(提交审核)
        public int RepertoryAddStatus(Repertory m)
        {
            string sql = string.Format("exec Repertory_Add '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'",
                m.RepertoryNumber, m.RepertoryTypeId, m.ManufacturersId, m.RoleId, m.RepertoryTime, m.MakeTime = DateTime.Now, m.AuditStatusId = 3, m.DrugRepertoryId, m.Remark);
            return db.ExecuteNonQuery(sql);
        }
        //删除入库信息
        public int RepertoryDel(int id)
        {
            string sql = "delete  from Repertory where Id in (" + id + ")";
            return db.ExecuteNonQuery(sql);
        }
        //绑定角色表
        public List<Role> RoleBandsel()
        {
            string sql = "select * from Role ";
            return db.GetToList<Role>(sql);
        }
        //添加药品入库信息
        public int DrugRepertoryAdd(DrugRepertory m)
        {
            string sql = string.Format("insert into DrugRepertory select Id from  Drug  where Id in ('{0}')", m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //显示药品入库信息
        public List<DrugRepertory> DrugRepertoryShow()
        {
            string sql =
                " select * from DrugRepertory r join  Drug d on r.DrugId=d.Id join Manufacturers m on m.Id = d.ManufacturersId join DrugType t  on t.Id=d.DrugTypeId";
            return db.GetToList<DrugRepertory>(sql);
        }
        //删除药品入库信息
        public int DrugRepertoryDel(int id)
        {
            string sql = " delete from DrugRepertory where Id=" + id;
            return db.ExecuteNonQuery(sql);
        }
        //入库详情审核通过
        public Repertory RepertoryFill(int id)
        {
            string sql = "select * from Repertory r join RepertoryType t on r.RepertoryTypeId = t.Id join Manufacturers m on r.ManufacturersId=m.Id join Role e on r.RoleId = e.Id join AuditStatus a on r.AuditStatusId = a.Id join DrugRepertory d on r.DrugRepertoryId=d.Id join Drug g on g.Id = d.DrugId join DrugType u on g.DrugTypeId = u.Id where r.Id= " + id;

            return db.GetToList<Repertory>(sql)[0];
        }
        //修改审核通过
        public int AuditStatusUptTG(Repertory m)
        {
            string sql = string.Format("update Repertory set AuditStatusId=2 where Id='{0}'", m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //修改审核未通过
        public int AuditStatusUptBTG(Repertory m)
        {
            string sql = string.Format("update Repertory set AuditStatusId=3 where Id='{0}'", m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //药品出库显示列表
        public List<OutRepertory> OutRepertoryShow()
        {
            string sql = "select * from OutRepertory o join OutRepertoryType t on o.OutRepertoryTypeId = t.Id join Role r on o.RoleId = r.Id join OutDrugRepertory d on o.OutDrugRepertoryId = d.Id join Drug g on d.DrugId = g.Id join AuditStatus s on o.AuditStatusId = s.Id";
            return db.GetToList<OutRepertory>(sql);
        }
        //绑定出库类型表
        public List<OutRepertoryType> OutRepertoryTypeBandsel()
        {
            string sql = "select * from OutRepertoryType ";
            return db.GetToList<OutRepertoryType>(sql);
        }
        //删除药品出库信息
        public int OutRepertoryDel(int id)
        {
            string sql = " delete from OutRepertory where Id=" + id;
            return db.ExecuteNonQuery(sql);
        }
        //添加到出库信息
        public int OutDrugRepertoryAdd(OutDrugRepertory m)
        {
            string sql = string.Format("insert into OutDrugRepertory select Id from  Drug  where Id in ('{0}')", m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //新增出库(直接提交)
        public int OutRepertoryAdd(OutRepertory m)
        {
            string sql = string.Format("exec OutRepertory_Add'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                m.OutRepertoryNumber, m.OutRepertoryTypeId, m.RoleId, m.OutRepertoryTime, m.MakeTime = DateTime.Now, m.AuditStatusId = 1, m.OutDrugRepertoryId, m.Remark);
            return db.ExecuteNonQuery(sql);
        }
        //新增入库(提交审核)
        public int OutRepertoryAddStatus(OutRepertory m)
        {
            string sql = string.Format("exec OutRepertory_Add'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                m.OutRepertoryNumber, m.OutRepertoryTypeId, m.RoleId, m.OutRepertoryTime, m.MakeTime = DateTime.Now, m.AuditStatusId = 3, m.OutDrugRepertoryId, m.Remark);
            return db.ExecuteNonQuery(sql);
        }
        //显示药品出库信息
        public List<OutDrugRepertory> OutDrugRepertoryShow()
        {
            string sql =
                " select * from OutDrugRepertory r join  Drug d on r.DrugId=d.Id join Manufacturers m on m.Id = d.ManufacturersId join DrugType t  on t.Id=d.DrugTypeId";
            return db.GetToList<OutDrugRepertory>(sql);
        }
        //删除药品出库信息
        public int OutDrugRepertoryDel(int id)
        {
            string sql = " delete from OutDrugRepertory where Id=" + id;
            return db.ExecuteNonQuery(sql);
        }
        //出库详情审核通过
        public OutRepertory OutRepertoryFill(int id)
        {
            string sql = "select * from OutRepertory r join OutRepertoryType t on r.OutRepertoryTypeId = t.Id join Role e on r.RoleId = e.Id join AuditStatus a on r.AuditStatusId = a.Id join OutDrugRepertory d on r.OutDrugRepertoryId = d.Id join Drug g on g.Id = d.DrugId join Manufacturers m on g.ManufacturersId=m.Id join DrugType u on g.DrugTypeId = u.Id where r.Id = " + id;

            return db.GetToList<OutRepertory>(sql)[0];
        }
        //修改出库审核通过
        public int OutAuditStatusUptTG(OutRepertory m)
        {
            string sql = string.Format("update OutRepertory set AuditStatusId=2 where Id='{0}'", m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //修改出库审核未通过
        public int OutAuditStatusUptBTG(OutRepertory m)
        {
            string sql = string.Format("update OutRepertory set AuditStatusId=3 where Id='{0}'", m.Id);
            return db.ExecuteNonQuery(sql);
        }

        //药品调价反填
        public Drug DrugadJustPriceFill(int id)
        {
            string sql = "select * from Repertory r join DrugRepertory d on r.DrugRepertoryId = d.Id join Drug g on g.Id = d.DrugId where g.Id ="+id;
            return db.GetToList<Drug>(sql)[0];                 
        }

        //原价调成现价
        public int NowSelling(Drug m)
        {
            string sql = string.Format("update Drug set DrugSelling='{0}' where Id='{1}'", m.DrugSelling, m.Id);
            return db.ExecuteNonQuery(sql);
        }
        //库存明细(库存表)
        public Repertory RepertoryXiang(int id)
        {
            string sql = "select * from Repertory r join RepertoryType t on t.Id=r.RepertoryTypeId join DrugRepertory d on r.DrugRepertoryId = d.Id join Drug g on d.DrugId = g.Id  where r.Id =" + id;

            return db.GetToList<Repertory>(sql)[0];
        }
        //出库存明细(出库存表)
        public OutRepertory OutRepertoryXiang(int id)
        {
            string sql = "select * from OutRepertory r join OutRepertoryType t on t.Id = r.OutRepertoryTypeId join OutDrugRepertory d on r.OutDrugRepertoryId = d.Id join Drug g on d.DrugId = g.Id  where r.Id = " + id;

            return db.GetToList<OutRepertory>(sql)[0];
        }
    }
}
