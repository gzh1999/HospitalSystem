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
            var sql = string.Format("update AddStaff set StaffName = '{0}' , StaffAge = '{1}',StaffSex = '{2}',StaffPhone = '{3}',StaffBelong = '{4}',StaffEmail = '{5}',StaffAddTimes = '{6}',StaffCertificateNumber = '{7}',  StaffSiteTionId = '{8}', StaffSiteTionContent = '{9}', OfficeName = '{10}',   RoleName  = '{11}',  StateIsok = '{12}' where Id = '{13}'",
                s.StaffName, s.StaffAge, s.StaffSex, s.StaffPhone, s.StaffBelong, s.StaffEmail, s.StaffAddTimes, s.StaffCertificateNumber, s.StaffSiteTionId, s.StaffSiteTionContent, s.OfficeName, s.RoleName, s.StateIsok, s.Id);
            return db.ExecuteNonQuery(sql);
        }
        //员工删除
        public int Del(int id)
        {
            var sql = "delete from  AddStaff where Id = " + id;
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
            var sql = string.Format("insert into Office values('{0}','{1}',{2},'{3}','{4}','{5}')",
                o.OfficeNumber, o.OfficeName, o.OfficeIntroduction, o.OfficeCreateTime, o.OfficePerson, o.OfficeStatus);
            return db.ExecuteNonQuery(sql);
        }
        //科室反填修改
        public Office Filloff(int id)
        {
            var sql = "select * from Office o join AddStaff a on o.Id = a.OfficeId where o.Id = " + id;
            return db.GetToList<Office>(sql)[0];
        }
        public int Uptoff(Office o)
        {
            var sql = string.Format("update Office set OfficeName = '{0}' , OfficeIntroduction = '{1}',OfficeCreateTime = '{2}',OfficePerson = '{3}',OfficeStatus = '{4}' where Id = '{5}'",
                o.OfficeName, o.OfficeIntroduction, o.OfficeCreateTime, o.OfficePerson, o.OfficeStatus, o.Id);
            return db.ExecuteNonQuery(sql);
        }
        //科室删除
        public int Deloff(int id)
        {
            var sql = "delete from Office where Id= " + id;
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
            var sql = string.Format("insert into Role values('{0}','{1}',(2),'{3}','{4}')",
                r.RoleName, r.RoleContent, r.RoleTime, r.CreatePerson, r.RoleStatus);
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
                r.RoleName, r.RoleContent, r.RoleTime, r.CreatePerson, r.RoleStatus, r.Id);
            return db.ExecuteNonQuery(sql);
        }
        //角色删除
        public int Delrole(int id)
        {
            var sql = "delete from Role where Id = " + id;
            return db.ExecuteNonQuery(sql);
        }
    }
}
