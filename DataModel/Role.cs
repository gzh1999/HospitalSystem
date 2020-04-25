using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role
    {
        public int Id { get; set; }
        public string RoleName     { get; set; }
        public string RoleContent  { get; set; }
        public DateTime RoleTime     { get; set; }
        public string CreatePerson { get; set; }
        public bool RoleStatus { get; set; }
    }
}
