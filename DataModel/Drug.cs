using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Drug
    {
        public int Id { get; set; }
        public string DrugNumber     { get; set; }
        public string DrugName       { get; set; }
        public decimal DrugPrice      { get; set; }
        public decimal DrugSelling    { get; set; }
        public string Manufacturers  { get; set; }
        public bool DrugStatus     { get; set; }
        public DateTime DrugCreateTime { get; set; }
    }
}
