using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class AttendanceReasonMaster
{
    public int AttendReasonId { get; set; }

    public string? AttendReasonCode { get; set; }

    public string? AttendReasonName { get; set; }

    public string? AttendReasonDescription { get; set; }

    public int AttendReasonCmpId { get; set; }

    public int AttendReasonSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<StudentAttendanceDetail> StudentAttendanceDetails { get; set; } = new List<StudentAttendanceDetail>();

    public virtual ICollection<StudentAttendanceDetailsHistory> StudentAttendanceDetailsHistories { get; set; } = new List<StudentAttendanceDetailsHistory>();
}
