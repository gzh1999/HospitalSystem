using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataModel;

namespace DAL
{
    public class dal
    {
        DBHelper db = new DBHelper();
        //商品列表显示
        string comStr = "Data Source=.;Initial Catalog=Hospitalystem;Integrated Security=True";
        public List<Menber> MenberShow()
        {
            using (var conn = new SqlConnection(comStr))
            {
                //打开数据库链接
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Menber a join Setting b on a.MenberTypeId=b.SettingId";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                var Shoplist = new List<Menber>();
                foreach (DataRow dr in dt.Rows)
                {
                    var m = new Menber();
                    m.MenberId = Convert.ToInt32(dr["MenberId"]);
                    m.MenberCard = Convert.ToInt32(dr["MenberCard"]);
                    m.MenberTypeId = Convert.ToString(dr["MenberTypeId"]);
                    m.MenberGrade = Convert.ToString(dr["MenberGrade"]);
                    m.MenberType = Convert.ToString(dr["MenberType"]);
                    m.SettingGrade = Convert.ToString(dr["SettingGrade"]);
                    m.MenberName = Convert.ToString(dr["MenberName"]);
                    m.MenberPhone = Convert.ToString(dr["MenberPhone"]);
                    m.Cumulative = Convert.ToDecimal(dr["Cumulative"]);
                    m.Storage = Convert.ToDecimal(dr["Storage"]);
                    m.Accumulative = Convert.ToDecimal(dr["Accumulative"]);
                    m.Integral = Convert.ToInt32(dr["Integral"]);
                    m.Activate = Convert.ToDateTime(dr["Activate"]);
                    m.Expiration = Convert.ToDateTime(dr["Expiration"]);
                    m.Condition = Convert.ToBoolean(dr["Condition"]);
                    Shoplist.Add(m);
                }
                return Shoplist;
            }
        }
        //绑定品牌列表下拉框
        public List<Setting> Brands()
        {
            using (var conn = new SqlConnection(comStr))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Setting";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                var Brands = new List<Setting>();
                foreach (DataRow dr in dt.Rows)
                {
                    var m = new Setting();
                    m.SettingId = Convert.ToInt32(dr["SettingId"]);
                    m.MenberType = Convert.ToString(dr["MenberType"]);
                    m.SettingGrade = Convert.ToString(dr["SettingGrade"]);
                    Brands.Add(m);
                }
                return Brands;
            }
        }
        public List<Setting> SettingShow()
        {
            using (var conn = new SqlConnection(comStr))
            {
                //打开数据库链接
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Setting";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                var Shoplist = new List<Setting>();
                foreach (DataRow dr in dt.Rows)
                {
                    var m = new Setting();
                    m.SettingId = Convert.ToInt32(dr["SettingId"]);
                    m.SettingGrade = Convert.ToString(dr["SettingGrade"]);
                    m.MenberType = Convert.ToString(dr["MenberType"]);
                    m.Discount = Convert.ToDecimal(dr["Discount"]);
                    m.Integral = Convert.ToInt32(dr["Integral"]);
                    m.Upgrade = Convert.ToInt32(dr["Upgrade"]);
                    m.Remarks = Convert.ToString(dr["Remarks"]);
                    m.Condition = Convert.ToBoolean(dr["Condition"]);
                    Shoplist.Add(m);
                }
                return Shoplist;
            }
        }
        public List<Menber> MenbeShow()
        {
            using (var conn = new SqlConnection(comStr))
            {
                //打开数据库链接
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Menber a join Setting b on a.MenberTypeId=b.SettingId";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                var Shoplist = new List<Menber>();
                foreach (DataRow dr in dt.Rows)
                {
                    var m = new Menber();
                    m.MenberId = Convert.ToInt32(dr["MenberId"]);
                    m.MenberCard = Convert.ToInt32(dr["MenberCard"]);
                    m.MenberTypeId = Convert.ToString(dr["MenberTypeId"]);
                    m.MenberGrade = Convert.ToString(dr["MenberGrade"]);
                    m.MenberType = Convert.ToString(dr["MenberType"]);
                    m.SettingGrade = Convert.ToString(dr["SettingGrade"]);
                    m.MenberName = Convert.ToString(dr["MenberName"]);
                    m.MenberPhone = Convert.ToString(dr["MenberPhone"]);
                    m.Cumulative = Convert.ToDecimal(dr["Cumulative"]);
                    m.Storage = Convert.ToDecimal(dr["Storage"]);
                    m.Accumulative = Convert.ToDecimal(dr["Accumulative"]);
                    m.Integral = Convert.ToInt32(dr["Integral"]);
                    m.Activate = Convert.ToDateTime(dr["Activate"]);
                    m.Expiration = Convert.ToDateTime(dr["Expiration"]);
                    m.Condition = Convert.ToBoolean(dr["Condition"]);
                    Shoplist.Add(m);
                }
                return Shoplist;
            }
        }
        public List<Menber> MenbShow()
        {
            using (var conn = new SqlConnection(comStr))
            {
                //打开数据库链接
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Menber a join Setting b on a.MenberTypeId=b.SettingId";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                var Shoplist = new List<Menber>();
                foreach (DataRow dr in dt.Rows)
                {
                    var m = new Menber();
                    m.MenberId = Convert.ToInt32(dr["MenberId"]);
                    m.MenberCard = Convert.ToInt32(dr["MenberCard"]);
                    m.MenberTypeId = Convert.ToString(dr["MenberTypeId"]);
                    m.MenberGrade = Convert.ToString(dr["MenberGrade"]);
                    m.MenberType = Convert.ToString(dr["MenberType"]);
                    m.SettingGrade = Convert.ToString(dr["SettingGrade"]);
                    m.MenberName = Convert.ToString(dr["MenberName"]);
                    m.MenberPhone = Convert.ToString(dr["MenberPhone"]);
                    m.Cumulative = Convert.ToDecimal(dr["Cumulative"]);
                    m.Storage = Convert.ToDecimal(dr["Storage"]);
                    m.Accumulative = Convert.ToDecimal(dr["Accumulative"]);
                    m.Integral = Convert.ToInt32(dr["Integral"]);
                    m.Activate = Convert.ToDateTime(dr["Activate"]);
                    m.Expiration = Convert.ToDateTime(dr["Expiration"]);
                    m.Condition = Convert.ToBoolean(dr["Condition"]);
                    Shoplist.Add(m);
                }
                return Shoplist;
            }
        }
        public int SettingAdd(Setting a)
        {
            string sql = string.Format("insert into Setting values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", a.SettingGrade, a.MenberType, a.Discount, a.Integral, a.Upgrade, a.Remarks, a.Condition, a.SettingId);
            return db.ExecuteNonQuery(sql);
        }

        //修改状态
        public int SettingUpt(Setting a)
        {
            string sql = string.Format("update Setting set Condition=Condition-1 where SettingId='{0}'", a.SettingId);
            return db.ExecuteNonQuery(sql);
        }
        public int MenberUpt(Menber a)
        {
            string sql = string.Format("update Menber set Condition=Condition-1 where MenberId='{0}'", a.MenberId);
            return db.ExecuteNonQuery(sql);
        }
        //反填
        public Menber MenberFill(int id)
        {
            string sql = "select * from Menber where Menber.MenberId=" + id;
            return db.GetToList<Menber>(sql)[0];
        }
    }
}
