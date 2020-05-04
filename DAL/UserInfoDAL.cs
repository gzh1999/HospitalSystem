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
        /// 编辑获取信息
        /// </summary>
        /// <param name="idd"></param>
        /// <returns></returns>
        public UsearInfoModel Fantian(string idd)
        {
            string sql = string.Format("select * from UserInfo where Uname='{0}'", idd);
            return db.GetToList<UsearInfoModel>(sql).FirstOrDefault();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateLog(UsearInfoModel model)
        {
            string sql = string.Format("update UserInfo set PassWord ='{0}',qqyouxiang='{1}' where Uname='{2}'", model.PassWord, model.qqyouxiang, model.Uname);
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
        public List<Workbench> ShowWork(string Birthdate, string PatientName)
        {
            List<Workbench> workbenchs = new List<Workbench>();
            string sql = string.Format("select Patient.PatientName,Patient.PatientAge,Patient.Birthdate,Patient.PatientPhone from Patient ");

            if (Birthdate != null)
            {
                workbenchs= workbenchs.Where(s => s.Birthdate == Birthdate).ToList();
            }
            if (PatientName != null)
            {
                workbenchs = workbenchs.Where(s => s.PatientName.Contains(PatientName)).ToList();
            }

            workbenchs = db.GetToList<Workbench>(sql);
            return workbenchs;
        }
    }
}
