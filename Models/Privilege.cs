using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class Privilege
{
    public int Id { get; set; }

    public string? Privilege1 { get; set; }

    public int? ParentId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
}
