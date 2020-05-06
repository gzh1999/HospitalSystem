using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
    public class HCXDAL
    {
        //实例化dbhelp
        DBHelper db = new DBHelper();
        //患者显示+查询
        public List<Patient> PatientShow(string name = "", string vip = "", string time = "")
        {
            string str = "select * from Patient p join Setting s on p.VIPTypeId = s.SettingId join Sex x on p.PatientSexId = x.Id where 1 =1 ";
            if (!string.IsNullOrEmpty(name))
            {
                str += " and PatientName like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(vip))
            {
                str += " and VIPTypeId = " + vip;
            }
            if (!string.IsNullOrEmpty(time))
            {
                str += $" and RegistrationTime = '{time}'";
            }
            return db.GetToList<Patient>(str);
        }//添加患者
        public int Add(Patient m)
        {
            string str = $"insert into Patient(PatientName,PatientCard,PatientAge,Birthdate,PatientSexId,PatientPhone,CertificateNumber,PatientSource,VIPTypeId,RegistrationTime,Ethnic,MaritalStatus,Education,SiteTionContent,Remark) values('{m.PatientName}','{m.PatientCard}',{m.PatientAge},'{m.Birthdate}',{(m.PatientSexId)},'{m.PatientPhone}','{m.CertificateNumber}','{m.PatientSource}','{m.VIPTypeId}','{m.RegistrationTime}','{m.Ethnic}','{m.MaritalStatus}','{m.Education}','{m.SiteTionContent}','{m.Remark}')";
            return db.ExecuteNonQuery(str);
        }
        //患者详情
        public Patient Find(int id)
        {
            string str = "select * from Patient p join Setting s on p.VIPTypeId = s.SettingId join Sex x on p.PatientSexId = x.Id where p.Id = " + id;
            return db.GetToList<Patient>(str)[0];
        }
        //编辑患者
        public int Update(Patient m)
        {
            string str = $"update Patient set PatientName = '{m.PatientName}',PatientCard = '{m.PatientCard}',PatientAge = {m.PatientAge},Birthdate = '{m.Birthdate}',PatientSexId = '{m.PatientSexId}',PatientPhone = '{m.PatientPhone}',CertificateNumber = '{m.CertificateNumber}',PatientSource = '{m.PatientSource}',VIPTypeId = '{m.VIPTypeId}',RegistrationTime = '{m.RegistrationTime}',Ethnic = '{m.Ethnic}',MaritalStatus = '{m.MaritalStatus}',SiteTionContent = '{m.SiteTionContent}',Education = '{m.Education}',Remark = '{m.Remark}' where Id = {m.Id}";
            return db.ExecuteNonQuery(str);
        }
        //删除患者
        public int Delete(int id)
        {
            string str = "delete from Patient where Id = " + id;
            return db.ExecuteNonQuery(str);
        }
        //性别下拉框
        public List<Sex> SexBand()
        {
            string str = "select * from Sex";
            return db.GetToList<Sex>(str);
        }

        //挂号显示+查询
        public List<Patient> RegistrationShow(string name = "", string office = "", string time = "")
        {
            string str = "select * from Patient p join Sex s on s.Id = p.PatientSexId join Office o on o.Id = p.OfficeId join AddStaff a on a.Id=p.AddStaffId where 1 =1 ";
            if (!string.IsNullOrEmpty(name))
            {
                str += " and PatientName like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(office))
            {
                str += " and OfficeId = " + office;
            }
            if (!string.IsNullOrEmpty(time))
            {
                str += $" and RegistrationTime = '{time}'";
            }
            return db.GetToList<Patient>(str);
        }

        //添加挂号

        public int RegistrationAdd(Patient m)
        {
            string str = $"insert into Patient(RegistrationNumber,PatientName,OfficeId,ReceptionType,AddStaffId,RegistrationFee,DiagnosisFee,RegistrationTime,RegistrationName,PatientState,PatientCard,PatientAge,Birthdate,PatientSexId,PatientPhone,SiteTionContent,Remark) values('{m.RegistrationNumber}','{m.PatientName}',{m.OfficeId},'{m.ReceptionType}',{m.AddStaffId},'{m.RegistrationFee}','{m.DiagnosisFee}','{m.RegistrationTime}','{m.RegistrationName}',{m.PatientState},'{m.PatientCard}',{m.PatientAge},'{m.Birthdate}',{(m.PatientSexId)},'{m.PatientPhone}','{m.SiteTionContent}','{m.Remark}')";
            return db.ExecuteNonQuery(str);
        }
        //挂号详情
        public Patient RegistrationFind(int id)
        {
            string str = "select p.*,o.OfficeName,a.StaffName from Patient p join Office o on o.Id = p.OfficeId join AddStaff a on a.Id=p.AddStaffId where p.Id = " + id;
            return db.GetToList<Patient>(str)[0];
        }
        //编辑挂号
        public int RegistrationUpdate(Patient m)
        {
            string str = $"update Patient set PatientName = '{m.PatientName}',PatientCard = '{m.PatientCard}',PatientAge = {m.PatientAge},Birthdate = '{m.Birthdate}',PatientSexId = '{m.PatientSexId}',PatientPhone = '{m.PatientPhone}',CertificateNumber = '{m.CertificateNumber}',SiteTionContent = '{m.SiteTionContent}',Remark = '{m.Remark}',OfficeId = {m.OfficeId},ReceptionType = '{m.ReceptionType}',AddStaffId = '{m.AddStaffId}',RegistrationFee = '{m.RegistrationFee}',DiagnosisFee = '{m.DiagnosisFee}' where Id = {m.Id}";
            return db.ExecuteNonQuery(str);
        }
        //挂号退号
        public int RegistrationDelete(int id)
        {
            string str = "delete from Patient where Id = " + id;
            return db.ExecuteNonQuery(str);
        }
        /// <summary>
        /// 接诊医生表
        /// </summary>
        /// <returns></returns>
        public List<AddStaff> AddStaffShow()
        {
            string str = "select * from AddStaff a join Role r on a.RoleId = r.Id where RoleName = '医生'";
            return db.GetToList<AddStaff>(str);
        }
    }
}
