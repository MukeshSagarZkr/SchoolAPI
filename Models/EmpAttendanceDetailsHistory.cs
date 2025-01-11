using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpAttendanceDetailsHistory
{
    public int EmpAttendhId { get; set; }

    public int EmpAttendhEmpId { get; set; }

    public int? EmpAttendhMonth { get; set; }

    public int? EmpAttendhYear { get; set; }

    public DateTime EmpAttendhDate { get; set; }

    public bool EmpAttendhStatus { get; set; }

    public int? EmpAttendhLeaveId { get; set; }

    public string? EmpAttendhTime { get; set; }

    public int EmpAttendhCmpId { get; set; }

    public int EmpAttendhSchId { get; set; }

    public bool? EmpAttendhIsHalfDay { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual EmpMaster EmpAttendhEmp { get; set; } = null!;
}
