using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpAttendanceDetail
{
    public int EmpAttendId { get; set; }

    public int EmpAttendEmpId { get; set; }

    public int? EmpAttendMonth { get; set; }

    public int? EmpAttendYear { get; set; }

    public DateTime EmpAttendDate { get; set; }

    public bool EmpAttendStatus { get; set; }

    public int? EmpAttendLeaveId { get; set; }

    public string? EmpAttendTime { get; set; }

    public int EmpAttendCmpId { get; set; }

    public int EmpAttendSchId { get; set; }

    public bool? EmpAttendIsHalfDay { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpMaster EmpAttendEmp { get; set; } = null!;
}
