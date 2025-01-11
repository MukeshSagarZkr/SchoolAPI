using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpLeaveDetailsHistory
{
    public int EmpldhId { get; set; }

    public int EmpldhEmpId { get; set; }

    public int EmpldhCatId { get; set; }

    public int EmpldhLeaveTypeId { get; set; }

    public decimal? EmpldhTotalLeaves { get; set; }

    public decimal? EmpldhPrevYearBalance { get; set; }

    public decimal? EmpldhCurrentBalance { get; set; }

    public string? EmpldhSession { get; set; }

    public int EmpldhCmpId { get; set; }

    public int EmpldhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpCategoryMaster EmpldhCat { get; set; } = null!;

    public virtual EmpMaster EmpldhEmp { get; set; } = null!;

    public virtual LeaveTypeMaster EmpldhLeaveType { get; set; } = null!;
}
