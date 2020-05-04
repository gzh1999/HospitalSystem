using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 分页表
    /// </summary>
    public class PageInfo
    {
        public List<Drug> drugs { get; set; }   //药品集合
        public List<Repertory> repertories { get; set; }  //库存集合
        public List<Workbench> workbenches { get; set; }   //工作台分页
        public List<Menber> menbers { get; set; }//会员表分页
        public List<Setting> settings { get; set; }//会员设置表分页
        public List<AddStaff> addStaffs { get; set; }   //员工表
        public List<Office> offices { get; set; }//科室表
        public List<Role> roles { get; set; }//角色表
        public int TotalCount { get; set; }  //总记录数
        public int TotalPage { get; set; }   //总页数
        public int CurrentPage { get; set; } //当前页
        public int PageSize { get; set; }  //每页记录数
    }
}
