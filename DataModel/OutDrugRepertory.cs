using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 药品出库信息表
    /// </summary>
    public class OutDrugRepertory
    {
        public int Id { get; set; }   //主键id
        public int DrugId { get; set; }  //药品表


        public string DrugNumber { get; set; }
        public string DrugName { get; set; }
        public decimal DrugPrice { get; set; }
        public decimal DrugSelling { get; set; }
        public int ManufacturersId { get; set; }
        public string ManufacturersName { get; set; }
        public int DrugCount { get; set; }
        public string DrugCreateTime { get; set; }
        public int DrugTypeId { get; set; }
        public string DrugTypeName { get; set; }

    }
}
