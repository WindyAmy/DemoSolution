using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogAppDAL.Entities
{
    /// <summary>
    /// 部分类实现分开定义属性
    /// </summary>
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
    }
}