using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Patient
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }     //挂号单号
        public string PatientName { get; set; }             //--患者姓名
        public int OfficeId { get; set; }                                   //科室外键2
        public string OfficeName { get; set; }                             //--科室名称2 
        public string ReceptionType { get; set; }     //接诊类型
        public int AddStaffId { get; set; }     //医生外键1
        public string StaffName { get; set; }    //医生姓名1
        public decimal RegistrationFee { get; set; }     //挂号费
        public decimal DiagnosisFee { get; set; }     //诊疗费
        public DateTime RegistrationTime { get; set; }     //挂号日期
        public string RegistrationName { get; set; }     //挂号员
        public int PatientState { get; set; }     //就诊状态
        public string PatientCard { get; set; }            //--患者卡号
        public int PatientAge { get; set; }            //-患者年龄	
        public DateTime Birthdate { get; set; }            //-出生日期
        public int PatientSexId { get; set; }            //-患者性别
        public string SexName { get; set; }
        public string PatientPhone { get; set; }            //-患者手机号
        public string CertificateNumber { get; set; }       //-证件号码
        public string PatientSource { get; set; }           //-患者来源
        public int VIPTypeId { get; set; }                 //-会员类型
        public string SettingGrade { get; set; }         //  会员等级
        public string Ethnic { get; set; }                  //-民族 
        public string MaritalStatus { get; set; }           //婚姻状态
        public string Education { get; set; }               //学历
        public string SiteTionContent { get; set; }         //地址详情
        public string Remark { get; set; }
    }
}
