using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class RolePrivilege
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int PrivilegeId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual Privilege Privilege { get; set; } = null!;

    public virtual RoleMaster Role { get; set; } = null!;
}
