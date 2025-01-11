using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpCatLeaveDetailsHistory
{
    public int EcathLeaveDetailId { get; set; }

    public int? EcathLeaveCatId { get; set; }

    public int? EcathLeaveTypeId { get; set; }

    public decimal? EcathLeaveTotalLeaves { get; set; }

    public string? EcathLeaveSession { get; set; }

    public int EcathLeaveSchId { get; set; }

    public int EcathLeaveCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpCategoryMaster? EcathLeaveCat { get; set; }

    public virtual LeaveTypeMaster? EcathLeaveType { get; set; }
}
