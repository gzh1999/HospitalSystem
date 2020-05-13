using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
    public class ZHCDAL
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
        public List<Setting> BrandSetting()
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
        //储值管理
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


        //充值
        public int chenge(decimal pays, int id)
        {
            string sql = string.Format("update Menber set Pay='{0}' where MenberId='{1}'", pays, id);
            return db.ExecuteNonQuery(sql);
        }

        public int change(int id)
        {
            string sql = string.Format("update Menber set Storage=Storage + Pay where MenberId='{0}'", +id);
            return db.ExecuteNonQuery(sql);
        }
        //退款
        public int chengtui1(decimal tui, int id)
        {
            string sql = string.Format("update Menber set Pay='{0}' where MenberId='{1}'", tui, id);
            return db.ExecuteNonQuery(sql);
        }
        public int changetui(int id)
        {
            string sql = string.Format("update Menber set Storage=Storage - Pay where MenberId='{0}'", +id);
            return db.ExecuteNonQuery(sql);
        }
        //赠送
        public int Drawback(decimal Drawbacks, int id)
        {
            string sql = string.Format("update Menber set Drawback='{0}' where MenberId='{1}'", Drawbacks, id);
            return db.ExecuteNonQuery(sql);
        }

        public int Drawback1(int id)
        {
            string sql = string.Format("update Menber set Accumulative=Accumulative + Drawback where MenberId='{0}'", +id);
            return db.ExecuteNonQuery(sql);
        }
        //增加积分
        public int Integral(decimal pays, int id)
        {
            string sql = string.Format("update Menber set Pay='{0}' where MenberId='{1}'", pays, id);
            return db.ExecuteNonQuery(sql);
        }

        public int Integral1(int id)
        {
            string sql = string.Format("update Menber set Integral=Integral + Pay where MenberId='{0}'", +id);
            return db.ExecuteNonQuery(sql);
        }
        //扣减积分
        public int Integraljian(decimal pays, int id)
        {
            string sql = string.Format("update Menber set Pay='{0}' where MenberId='{1}'", pays, id);
            return db.ExecuteNonQuery(sql);
        }

        public int Integraljian1(int id)
        {
            string sql = string.Format("update Menber set Integral=Integral - Pay where MenberId='{0}'", +id);
            return db.ExecuteNonQuery(sql);
        }
        //积分清零
        public int Integralling(int id)
        {
            string sql = string.Format("update Menber set Integral=Integral - Integral where MenberId='{0}'", +id);
            return db.ExecuteNonQuery(sql);
        }
    }
}
