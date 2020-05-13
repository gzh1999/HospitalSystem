using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 药品表
    /// </summary>
    public class Drug
    {
        public int Id { get; set; }
        public string DrugNumber     { get; set; }
        public string DrugName       { get; set; }
        public decimal DrugPrice      { get; set; }
        public decimal DrugSelling    { get; set; }
        public int ManufacturersId { get; set; }
        public bool DrugStatus     { get; set; }
        public string DrugCreateTime { get; set; }
        public int DrugTypeId { get; set; }
        public string Specification { get; set; }
        public int InventoryUpperLimit { get; set; }
        public int InventoryLowerLimit { get; set; }
        public string DrugContent { get; set; }
        public int DrugCount { get; set; }



        public string DrugTypeName { get; set; }
        public string ManufacturersName { get; set; }


        //反填库存编号
        public string RepertoryNumber { get; set; }

    }
}
