using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentAttendanceDetail
{
    public int StuAttendId { get; set; }

    public Guid StuAttendGuid { get; set; }

    public int StuAttendCmId { get; set; }

    public int StuAttendSecId { get; set; }

    public int? StuAttendMonth { get; set; }

    public int? StuAttendYear { get; set; }

    public DateTime StuAttendDate { get; set; }

    public bool StuAttendStatus { get; set; }

    public int? StuAttendReasonId { get; set; }

    public string? StuAttendTime { get; set; }

    public int StuAttendCmpId { get; set; }

    public int StuAttendSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual StudentMaster StuAttend { get; set; } = null!;

    public virtual ClassMaster StuAttendCm { get; set; } = null!;

    public virtual AttendanceReasonMaster? StuAttendReason { get; set; }
}
