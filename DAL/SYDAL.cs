using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
    public class SYDAL
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 员工
        /// </summary>
        /// <param name="OfficeName"></param>
        /// <param name="StaffName"></param>
        /// <returns></returns>
        //员工显示
        public List<AddStaff> Show()
        {
            var sql = "select * from  AddStaff a join Office o on o.Id=a.OfficeId join Role r on r.Id=a.RoleId";
            return db.GetToList<AddStaff>(sql);
        }
        //员工添加
        public int Add(AddStaff s)
        {
            var sql = string.Format("insert into AddStaff values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                s.StaffNumber, s.StaffName, s.StaffAge, s.StaffSex, s.StaffPhone, s.StaffBelong, s.StaffEmail, s.StaffAddTimes = DateTime.Now, s.StaffCertificateNumber, s.StaffSiteTionId, s.StaffSiteTionContent ,s.OfficeId, s.RoleId, s.StateIsok,s.StaffPosition);
            return db.ExecuteNonQuery(sql);
        }
        //员工反填修改
        public AddStaff Fill(int id)
        {
            var sql = "select * from  AddStaff a join Office o on o.Id = a.OfficeId join Role r on a.RoleId = r.Id where a.Id = " + id;
            return db.GetToList<AddStaff>(sql)[0];
        }
        public int Upt(AddStaff s)
        {
            var sql = string.Format("update AddStaff set StaffNumber='{0}',StaffName='{1}',StaffAge='{2}',StaffSex='{3}',StaffPhone='{4}',StaffBelong='{5}',StaffEmail='{6}',StaffAddTimes='{7}',StaffCertificateNumber='{8}',StaffSiteTionId='{9}',StaffSiteTionContent='{10}',OfficeId='{11}',RoleId='{12}',StateIsok='{13}',StaffPosition='{14}' where Id='{15}'",
                s.StaffNumber, s.StaffName, s.StaffAge, s.StaffSex, s.StaffPhone, s.StaffBelong, s.StaffEmail, s.StaffAddTimes = DateTime.Now, s.StaffCertificateNumber, s.StaffSiteTionId, s.StaffSiteTionContent, s.OfficeId, s.RoleId, s.StateIsok, s.StaffPosition, s.Id);
            return db.ExecuteNonQuery(sql);
        }
        //员工删除
        public int Del(string id)
        {
            var sql = "delete from  AddStaff where Id in (" + id + ") ";
            return db.ExecuteNonQuery(sql);
        }
        //员工状态修改
        public int UptStatus(AddStaff s)
        {
            var sql = string.Format("update AddStaff set StateIsok=StateIsok - 1 where Id='{0}'", s.Id);
            return db.ExecuteNonQuery(sql);
        }


        //绑定科室下拉
        public List<Office> BandOffice()
        {
            var sql = "select * from Office";
            return db.GetToList<Office>(sql);
        }
        //绑定角色下拉
        public List<Role> BandRole()
        {
            var sql = "select * from Role";
            return db.GetToList<Role>(sql);
        }
        //绑定省份的下拉  二级联动
        public List<AddStaff> SelectPro()
        {
            var sql = "select * from Address where AddressParentid = 0";
            return db.GetToList<AddStaff>(sql);
        }
        //绑定城市份的下拉
        public List<AddStaff> SelectCity(int proid)
        {
            var sql = "select * from Address where AddressParentid = " + proid;
            return db.GetToList<AddStaff>(sql);
        }


        /// <summary>
        /// 科室
        /// </summary>
        //科室显示
        public List<Office> Showoff()
        {
            var sql = "select * from Office ";
            return db.GetToList<Office>(sql);
        }
        //科室添加
        public int Addoff(Office o)
        {
            var sql = string.Format("insert into Office values('{0}','{1}','{2}','{3}','{4}','{5}')",
                o.OfficeNumber, o.OfficeName, o.OfficeIntroduction, o.OfficeCreateTime = DateTime.Now, o.OfficePerson, o.OfficeStatus);
            return db.ExecuteNonQuery(sql);
        }
        //科室反填修改
        public Office Filloff(int id)
        {
            var sql = "select * from Office where Id = " + id;
            return db.GetToList<Office>(sql)[0];
        }
        public int Uptoff(Office o)
        {
            var sql = string.Format("update Office set OfficeName = '{0}' , OfficeIntroduction = '{1}',OfficeCreateTime = '{2}',OfficePerson = '{3}',OfficeStatus = '{4}' where Id = '{5}'",
                o.OfficeName, o.OfficeIntroduction, o.OfficeCreateTime = DateTime.Now, o.OfficePerson, o.OfficeStatus, o.Id);
            return db.ExecuteNonQuery(sql);
        }
        //科室修改状态
        public int UptStatussoff(Office o)
        {
            var sql = string.Format("update Office set OfficeStatus=OfficeStatus - 1 where Id='{0}'", o.Id);
            return db.ExecuteNonQuery(sql);
        }
        //科室删除
        public int Deloff(string id)
        {
            var sql = "delete from Office where Id in (" + id + ") ";
            return db.ExecuteNonQuery(sql);
        }



        /// <summary>
        /// 角色
        /// </summary>
        //角色显示
        public List<Role> Showrole()
        {
            var sql = "select * from Role";
            return db.GetToList<Role>(sql);
        }
        //角色添加
        public int Addrole(Role r)
        {
            var sql = string.Format("insert into Role values('{0}','{1}','{2}','{3}','{4}')",
                r.RoleName, r.RoleContent, r.RoleTime = DateTime.Now, r.CreatePerson, r.RoleStatus);
            return db.ExecuteNonQuery(sql);
        }
        //角色反填修改
        public Role Fillrole(int id)
        {
            var sql = "select * from  Role where Id = " + id;
            return db.GetToList<Role>(sql)[0];
        }
        public int Uptrole(Role r)
        {
            var sql = string.Format("update Role set RoleName = '{0}' , RoleContent = '{1}',RoleTime = '{2}',CreatePerson = '{3}',RoleStatus = '{4}' where Id = '{5}'",
                r.RoleName, r.RoleContent, r.RoleTime = DateTime.Now, r.CreatePerson, r.RoleStatus, r.Id);
            return db.ExecuteNonQuery(sql);
        }
        //角色修改状态
        public int UptStatussrole(Role r)
        {
            var sql = string.Format("update Role set RoleStatus=RoleStatus - 1 where Id='{0}'", r.Id);
            return db.ExecuteNonQuery(sql);
        }
        //角色删除
        public int Delrole(string id)
        {
            var sql = "delete from Role where Id in (" + id + ") ";
            return db.ExecuteNonQuery(sql);
        }
    }
}
