using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 出库管理
    /// </summary>
    public class OutRepertory
    {
        public int Id { get; set; }
        public string OutRepertoryNumber { get; set; }   //出库编号
        public int OutRepertoryTypeId { get; set; }    //出库类型
        public int RoleId { get; set; }   //入库人员
        public DateTime OutRepertoryTime { get; set; }   //创建时间
        public DateTime MakeTime { get; set; }  //制单日期
        public int AuditStatusId { get; set; }  //审核表外键
        public int OutDrugRepertoryId { get; set; }  //入库信息表外键
        public string Remark { get; set; }   //备注



        //显示外键
        public string OutRepertoryTypeName { get; set; }
        public string CreatePerson { get; set; }
        public string AuditStatusName { get; set; }
        public decimal DrugPrice { get; set; }
        public decimal DrugSelling { get; set; }



        //反填时候的显示药品
        public string DrugNumber { get; set; }
        public string DrugName { get; set; }
        public int ManufacturersId { get; set; }
        public int DrugCount { get; set; }
        public string DrugCreateTime { get; set; }
        public string DrugTypeName { get; set; }
        public int InventoryUpperLimit { get; set; }
        public string ManufacturersName { get; set; }
    }
}
