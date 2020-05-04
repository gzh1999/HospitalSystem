using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Menber
    {
        public int MenberId { get; set; }
        public int MenberCard { get; set; }
        public string MenberTypeId { get; set; }
        public string MenberGrade { get; set; }
        public string MenberName { get; set; }
        public string MenberPhone { get; set; }
        public decimal Cumulative { get; set; }
        public decimal Storage { get; set; }
        public decimal Accumulative { get; set; }
        public int Integral { get; set; }
        public DateTime Activate { get; set; }
        public DateTime Expiration { get; set; }
        public bool Condition { get; set; }
        public string SettingGrade { get; set; }
        public string MenberType { get; set; }
        public string Pay { get; set; }
        public string Drawback { get; set; }
    }
    public class Setting
    {
        public int SettingId { get; set; }
        public string SettingGrade { get; set; }
        public string MenberType { get; set; }
        public decimal Discount { get; set; }
        public int Integral { get; set; }
        public int Upgrade { get; set; }
        public string Remarks { get; set; }
        public bool Condition { get; set; }
    }
    public class PageInfor
    {
        public List<Menber> shopModels { get; set; }
        //当前页
        public int CurrentPage { get; set; }
        //总记录数
        public int TotalCount { get; set; }
        //总页数
        public int TotalPage { get; set; }
    }
    public class PageInfo
    {
        public List<Setting> Settings { get; set; }
        //当前页
        public int CurrentPage { get; set; }
        //总记录数
        public int TotalCount { get; set; }
        //总页数
        public int TotalPage { get; set; }
    }
}
