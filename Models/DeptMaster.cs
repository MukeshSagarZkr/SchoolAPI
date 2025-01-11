using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class DeptMaster
{
    public int DeptId { get; set; }

    public string? DeptCode { get; set; }

    public string? DeptName { get; set; }

    public int DeptCmpId { get; set; }

    public int DeptSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<DeptDesigDetail> DeptDesigDetails { get; set; } = new List<DeptDesigDetail>();

    public virtual ICollection<EmpMaster> EmpMasters { get; set; } = new List<EmpMaster>();

    public virtual ICollection<HolidayDeptDetail> HolidayDeptDetails { get; set; } = new List<HolidayDeptDetail>();
}
