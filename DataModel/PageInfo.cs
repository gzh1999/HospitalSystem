using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class PageInfo
    {
        public List<Drug> drugs { get; set; }
        public int TotalCount { get; set; }  //总记录数
        public int TotalPage { get; set; }   //总页数
        public int CurrentPage { get; set; } //当前页
        public int PageSize { get; set; }  //每页记录数
    }
}
