//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleInfo
    {
        public int ID { get; set; }
        public int SystemId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Category { get; set; }
        public string Remark { get; set; }
        public bool IsEnable { get; set; }
        public int SortIndex { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public int ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}
