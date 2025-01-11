using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class LeaveTypeMaster
{
    public int LeaveTypeId { get; set; }

    public string? LeaveTypeCode { get; set; }

    public string? LeaveTypeDescription { get; set; }

    public string? LeaveTypeApplicableGender { get; set; }

    public bool LeaveTypeIsSpecialLeave { get; set; }

    public bool LeaveTypeIsEncashable { get; set; }

    public bool LeaveTypeIsCarryForward { get; set; }

    public int LeaveTypeCmpId { get; set; }

    public int LeaveTypeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<EmpCatLeaveDetail> EmpCatLeaveDetails { get; set; } = new List<EmpCatLeaveDetail>();

    public virtual ICollection<EmpCatLeaveDetailsHistory> EmpCatLeaveDetailsHistories { get; set; } = new List<EmpCatLeaveDetailsHistory>();

    public virtual ICollection<EmpLeaveAvailDetail> EmpLeaveAvailDetails { get; set; } = new List<EmpLeaveAvailDetail>();

    public virtual ICollection<EmpLeaveDetail> EmpLeaveDetails { get; set; } = new List<EmpLeaveDetail>();

    public virtual ICollection<EmpLeaveDetailsHistory> EmpLeaveDetailsHistories { get; set; } = new List<EmpLeaveDetailsHistory>();
}
