using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableSubstitutionDetailsHistory
{
    public int TtsubsdhId { get; set; }

    public int TtsubsdhPeriodId { get; set; }

    public int TtsubsdhTeacherId { get; set; }

    public int TtsubsdhTeacherIdNew { get; set; }

    public int TtsubsdhSubId { get; set; }

    public int TtsubsdhCmId { get; set; }

    public int TtsubsdhSecId { get; set; }

    public int TtsubsdhDayOfWeek { get; set; }

    public DateTime TtsubsdhSubstitutionDate { get; set; }

    public int TtsubsdhSessionId { get; set; }

    public string? TtsubsdhSession { get; set; }

    public int TtsubsdhCmpId { get; set; }

    public int TtsubsdhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TtsubsdhCm { get; set; } = null!;

    public virtual ClassSectionDetail TtsubsdhSec { get; set; } = null!;

    public virtual TimeTableSession TtsubsdhSessionNavigation { get; set; } = null!;

    public virtual SubjectMaster TtsubsdhSub { get; set; } = null!;

    public virtual EmpMaster TtsubsdhTeacher { get; set; } = null!;

    public virtual EmpMaster TtsubsdhTeacherIdNewNavigation { get; set; } = null!;
}
