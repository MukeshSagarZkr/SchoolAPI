using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentAttendanceDetailsHistory
{
    public int StuAttendhId { get; set; }

    public Guid StuAttendhGuid { get; set; }

    public int StuAttendhCmId { get; set; }

    public int StuAttendhSecId { get; set; }

    public int? StuAttendhMonth { get; set; }

    public int? StuAttendhYear { get; set; }

    public DateTime StuAttendhDate { get; set; }

    public bool StuAttendhStatus { get; set; }

    public int? StuAttendhReasonId { get; set; }

    public string? StuAttendhTime { get; set; }

    public int StuAttendhCmpId { get; set; }

    public int StuAttendhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual StudentMaster StuAttendh { get; set; } = null!;

    public virtual ClassMaster StuAttendhCm { get; set; } = null!;

    public virtual AttendanceReasonMaster? StuAttendhReason { get; set; }
}
