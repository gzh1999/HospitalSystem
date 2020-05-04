using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class SetAdd
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