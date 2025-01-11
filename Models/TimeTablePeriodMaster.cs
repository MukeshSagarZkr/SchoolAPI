using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTablePeriodMaster
{
    public int TtperiodId { get; set; }

    public string TtperiodDesctiption { get; set; } = null!;

    public int TtperiodNumber { get; set; }

    public TimeOnly TtperiodStartTime { get; set; }

    public TimeOnly TtperiodEndTime { get; set; }

    public int TtperiodTtsessionId { get; set; }

    public string? TtperiodSession { get; set; }

    public int TtperiodCmpId { get; set; }

    public int TtperiodSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<TimeTableClassPeriodDetail> TimeTableClassPeriodDetails { get; set; } = new List<TimeTableClassPeriodDetail>();

    public virtual ICollection<TimeTableSubstitutionDetail> TimeTableSubstitutionDetails { get; set; } = new List<TimeTableSubstitutionDetail>();

    public virtual TimeTableSession TtperiodTtsession { get; set; } = null!;
}
