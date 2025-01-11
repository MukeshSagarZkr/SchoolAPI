using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpCatLeaveDetail
{
    public int EcatLeaveDetailId { get; set; }

    public int? EcatLeaveCatId { get; set; }

    public int? EcatLeaveTypeId { get; set; }

    public decimal? EcatLeaveTotalLeaves { get; set; }

    public string? EcatLeaveSession { get; set; }

    public int EcatLeaveSchId { get; set; }

    public int EcatLeaveCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpCategoryMaster? EcatLeaveCat { get; set; }

    public virtual LeaveTypeMaster? EcatLeaveType { get; set; }
}
