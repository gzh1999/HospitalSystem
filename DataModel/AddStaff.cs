using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 员工表
    /// </summary>
    public class AddStaff
    {
        public int Id { get; set; }
        [Required]
        public string StaffNumber { get; set; }
        [Required]
        public string StaffName { get; set; }
        [Required]
        public int StaffAge { get; set; }
        [Required]
        public bool StaffSex { get; set; }
        [Required]
        public string StaffPhone { get; set; }
        [Required]
        public string StaffBelong { get; set; }
        [Required]
        public string StaffEmail { get; set; }
        [Required]
        public DateTime StaffAddTimes { get; set; }
        [Required]
        public string StaffCertificateNumber { get; set; }
        [Required]
        public string StaffSiteTionId { get; set; }   //二级联动id
        [Required]
        public string StaffSiteTionContent { get; set; }
        [Required]
        public int OfficeId { get; set; }
        [Required]
        public string OfficeName { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public bool StateIsok { get; set; }
        [Required]
        public string CreatePerson { get; set; }
        [Required]
        public string StaffPosition { get; set; }

        public string AddressName { get; set; }
        [Required]
        public int AddressParentid { get; set; }

    }
}
