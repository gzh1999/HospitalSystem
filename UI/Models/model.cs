using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
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
}