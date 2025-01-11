using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpTypeMaster
{
    public int EmpTypeId { get; set; }

    public string? EmpTypeName { get; set; }

    public string? EmpTypeDesc { get; set; }

    public int EmpTypeCmpId { get; set; }

    public int EmpTypeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<EmpMaster> EmpMasters { get; set; } = new List<EmpMaster>();
}
