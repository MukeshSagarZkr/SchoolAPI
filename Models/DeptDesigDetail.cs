using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class DeptDesigDetail
{
    public int DepdesId { get; set; }

    public int DepdesDeptId { get; set; }

    public int DepdesDesigId { get; set; }

    public int DepdesCmpId { get; set; }

    public int DepdesSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DeptMaster DepdesDept { get; set; } = null!;

    public virtual DesigMaster DepdesDesig { get; set; } = null!;

    public virtual ICollection<EmpMaster> EmpMasters { get; set; } = new List<EmpMaster>();
}
