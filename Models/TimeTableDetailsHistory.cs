using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableDetailsHistory
{
    public int TtdetailhId { get; set; }

    public int TtdetailhPeriodId { get; set; }

    public int TtdetailhTeacherId { get; set; }

    public int TtdetailhCmId { get; set; }

    public int TtdetailhSecId { get; set; }

    public int TtdetailhSubId { get; set; }

    public int TtdetailhDayOfWeek { get; set; }

    public int TtdetailhSessionId { get; set; }

    public string? TtdetailhSession { get; set; }

    public int TtdetailhCmpId { get; set; }

    public int TtdetailhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TtdetailhCm { get; set; } = null!;

    public virtual ClassSectionDetail TtdetailhSec { get; set; } = null!;

    public virtual TimeTableSession TtdetailhSessionNavigation { get; set; } = null!;

    public virtual SubjectMaster TtdetailhSub { get; set; } = null!;

    public virtual EmpMaster TtdetailhTeacher { get; set; } = null!;
}
