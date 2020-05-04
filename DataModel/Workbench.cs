using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    //工作台患者
    public class Workbench
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string PatientCard { get; set; }
        public int PatientAge { get; set; }
        public string Birthdate { get; set; }
        public bool PatientSex { get; set; }
        public string PatientPhone { get; set; }
        public string CertificateNumber { get; set; }
        public string PatientSource { get; set; }
        public string VIPType { get; set; }
        public DateTime ExpireTime { get; set; }
        public string Ethnic { get; set; }
        public string MaritalStatus { get; set; }
        public string Education { get; set; }
        public int SiteTionId { get; set; }
        public string SiteTionContent { get; set; }
        public string Occupation { get; set; }
        public string Experience { get; set; }
        public string Remark { get; set; }
    }
}
