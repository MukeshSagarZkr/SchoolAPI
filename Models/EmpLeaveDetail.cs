using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpLeaveDetail
{
    public int EmpldId { get; set; }

    public int EmpldEmpId { get; set; }

    public int EmpldCatId { get; set; }

    public int EmpldLeaveTypeId { get; set; }

    public decimal? EmpldTotalLeaves { get; set; }

    public decimal? EmpldPrevYearBalance { get; set; }

    public decimal? EmpldCurrentBalance { get; set; }

    public string? EmpldSession { get; set; }

    public int EmpldCmpId { get; set; }

    public int EmpldSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpCategoryMaster EmpldCat { get; set; } = null!;

    public virtual EmpMaster EmpldEmp { get; set; } = null!;

    public virtual LeaveTypeMaster EmpldLeaveType { get; set; } = null!;
}
