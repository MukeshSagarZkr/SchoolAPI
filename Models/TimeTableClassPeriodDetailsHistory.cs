using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableClassPeriodDetailsHistory
{
    public int TtclpdhId { get; set; }

    public int TtclpdhCmId { get; set; }

    public int TtclpdhSecId { get; set; }

    public int? TtclpdhSubId { get; set; }

    public int TtclpdhPeriodId { get; set; }

    public int TtclpdhDayOfWeek { get; set; }

    public int TtclpdhSessionId { get; set; }

    public string? TtclpdhSession { get; set; }

    public int TtclpdhCmpId { get; set; }

    public int TtclpdhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TtclpdhCm { get; set; } = null!;

    public virtual ClassSectionDetail TtclpdhSec { get; set; } = null!;

    public virtual TimeTableSession TtclpdhSessionNavigation { get; set; } = null!;

    public virtual SubjectMaster? TtclpdhSub { get; set; }
}
