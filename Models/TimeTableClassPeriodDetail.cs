using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableClassPeriodDetail
{
    public int TtclpdId { get; set; }

    public int TtclpdCmId { get; set; }

    public int TtclpdSecId { get; set; }

    public int? TtclpdSubId { get; set; }

    public int TtclpdPeriodId { get; set; }

    public int TtclpdDayOfWeek { get; set; }

    public int TtclpdSessionId { get; set; }

    public int TtclpdCmpId { get; set; }

    public int TtclpdSchId { get; set; }

    public string? TtclpdSession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TtclpdCm { get; set; } = null!;

    public virtual TimeTablePeriodMaster TtclpdPeriod { get; set; } = null!;

    public virtual ClassSectionDetail TtclpdSec { get; set; } = null!;

    public virtual TimeTableSession TtclpdSessionNavigation { get; set; } = null!;

    public virtual SubjectMaster? TtclpdSub { get; set; }
}
