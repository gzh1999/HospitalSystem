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
        public DateTime DrugCreateTime { get; set; }
        public int DrugTypeId { get; set; }
    }
}
