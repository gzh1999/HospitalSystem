using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 地址表
    /// </summary>
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public string AddressName { get; set; }
        [Required]
        public int AddressParentid { get; set; }
    }
}
