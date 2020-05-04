using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 科室表
    /// </summary>
    public class Office
    {
        public int Id { get; set; }
        [Required]
        public string OfficeNumber { get; set; }
        [Required]
        public string OfficeName { get; set; }
        [Required]
        public string OfficeIntroduction { get; set; }
        [Required]
        public DateTime OfficeCreateTime { get; set; }
        [Required]
        public string OfficePerson { get; set; }
        [Required]
        public bool OfficeStatus { get; set; }
    }
}
