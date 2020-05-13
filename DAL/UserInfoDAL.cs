using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
    public class UserInfoDAL
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="zh"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int LoginIf(string zh, string pwd)
        {
            string sql = string.Format("select count(1) from UserInfo where Uname='{0}' and PassWord='{1}'", zh, pwd);
            return (int)db.ExecuteScalar(sql);
        }

        /// <summary>
        /// 查找id
        /// </summary>
        /// <param name="idd"></param>
        /// <returns></returns>
        public UsearInfoModel FantianName(string Name)
        {
            string sql = string.Format("select UserInfo.Id from UserInfo where Uname='{0}'" , Name);
            return db.GetToList<UsearInfoModel>(sql).FirstOrDefault();
        }
        /// <summary>
        /// 编辑获取信息
        /// </summary>
        /// <param name="idd"></param>
        /// <returns></returns>
        public UsearInfoModel Fantian(int idd)
        {
            string sql = string.Format("select * from UserInfo where Id='{0}'" , idd);
            return db.GetToList<UsearInfoModel>(sql).FirstOrDefault();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateLog(UsearInfoModel model)
        {
            string sql = string.Format("update UserInfo set PassWord ='{0}',qqyouxiang='{1}' where Id='{2}'", model.PassWord, model.qqyouxiang, model.Id);
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddLogin(UsearInfoModel model)
        {
            string sql = string.Format("insert into UserInfo values('{0}','{1}','{2}')", model.Uname, model.PassWord, model.qqyouxiang);
            return db.ExecuteNonQuery(sql);
        }
        //工作台
        public List<Patient> ShowWork(string Birthdate, string PatientName)
        {
            List<Patient> workbenchs = new List<Patient>();
            string sql = string.Format("select pp.Id,pp.PatientPhone,pp.PatientName,pp.PatientAge,pp.Birthdate,o.OfficeName,a.StaffName from Patient pp join Sex s on s.Id = pp.PatientSexId join Office o on o.Id = pp.OfficeId join AddStaff a on a.Id=pp.AddStaffId ");
            workbenchs = db.GetToList<Patient>(sql);
            if (Birthdate != null)
            {
                workbenchs = workbenchs.Where(s => s.Birthdate == DateTime.Parse(Birthdate)).ToList();
            }
            if (PatientName != null)
            {
                workbenchs = workbenchs.Where(s => s.PatientName.Contains(PatientName)).ToList();
            }

            return workbenchs;
        }
    }
}
