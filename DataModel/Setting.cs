using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 张海超会员设置表
    /// </summary>
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
}
