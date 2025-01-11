using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpLeaveAvailDetail
{
    public int EmpladId { get; set; }

    public int EmpladEmpId { get; set; }

    public int EmpladLeaveTypeId { get; set; }

    public DateTime EmpladApplyDate { get; set; }

    public DateTime EmpladStartDate { get; set; }

    public DateTime EmpladEndDate { get; set; }

    public decimal? EmpladTotalDays { get; set; }

    public bool EmpladIsHalfDay { get; set; }

    public string? EmpladReason { get; set; }

    public string? EmpladAddress { get; set; }

    public string? EmpladContactNumber { get; set; }

    public int EmpladStatusId { get; set; }

    public string? EmpladSession { get; set; }

    public int EmpladCmpId { get; set; }

    public int EmpladSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpMaster EmpladEmp { get; set; } = null!;

    public virtual LeaveTypeMaster EmpladLeaveType { get; set; } = null!;

    public virtual LeaveStatusMaster EmpladStatus { get; set; } = null!;
}
