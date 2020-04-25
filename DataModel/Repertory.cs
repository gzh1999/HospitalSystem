using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 库存表
    /// </summary>
    public class Repertory
    {
        public int Id { get; set; }
        public string RepertoryNumber  { get; set; }
        public int RepertoryTypeId  { get; set; }
        public int ManufacturersId { get; set; }
        public int RoleId           { get; set; }
        public decimal AmountOfPurchase { get; set; }
        public DateTime RepertoryTime { get; set; }
        public DateTime MakeTime { get; set; }
        public int AuditStatusId { get; set; }
        public int DrugId { get; set; }
        public string Remark { get; set; }



        public string RepertoryTypeName { get; set; }
        public string ManufacturersName { get; set; }
        public string RoleName { get; set; }
        public string AuditStatusName { get; set; }
    }                 
}
