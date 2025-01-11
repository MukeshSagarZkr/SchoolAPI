using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableSubstitutionDetail
{
    public int TtsubsdId { get; set; }

    public int TtsubsdPeriodId { get; set; }

    public int TtsubsdTeacherId { get; set; }

    public int TtsubsdTeacherIdNew { get; set; }

    public int TtsubsdSubId { get; set; }

    public int TtsubsdCmId { get; set; }

    public int TtsubsdSecId { get; set; }

    public int TtsubsdDayOfWeek { get; set; }

    public DateTime TtsubsdSubstitutionDate { get; set; }

    public int TtsubsdSessionId { get; set; }

    public string? TtsubsdSession { get; set; }

    public int TtsubsdCmpId { get; set; }

    public int TtsubsdSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TtsubsdCm { get; set; } = null!;

    public virtual TimeTablePeriodMaster TtsubsdPeriod { get; set; } = null!;

    public virtual ClassSectionDetail TtsubsdSec { get; set; } = null!;

    public virtual TimeTableSession TtsubsdSessionNavigation { get; set; } = null!;

    public virtual SubjectMaster TtsubsdSub { get; set; } = null!;

    public virtual EmpMaster TtsubsdTeacher { get; set; } = null!;

    public virtual EmpMaster TtsubsdTeacherIdNewNavigation { get; set; } = null!;
}
