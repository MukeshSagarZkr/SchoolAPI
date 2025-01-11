using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class RoleMaster
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDescription { get; set; }

    public int RoleCmpId { get; set; }

    public int RoleSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();

    public virtual ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();
}
