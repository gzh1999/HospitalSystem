using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 张海超会员表
    /// </summary>
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
        public decimal Pay { get; set; }
        public decimal Drawback { get; set; }
    }
}
