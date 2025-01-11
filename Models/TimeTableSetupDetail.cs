using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableSetupDetail
{
    public int TtsetupId { get; set; }

    public TimeOnly TtsetupSchoolStartTime { get; set; }

    public TimeOnly TtsetupSchoolEndTime { get; set; }

    public TimeOnly TtsetupPeriodStartTime { get; set; }

    public int TtsetupTotalPeriods { get; set; }

    public int TtsetupPeriodDuration { get; set; }

    public int TtsetupReccessDuration { get; set; }

    public int TtsetupReccessAfterPeriod { get; set; }

    public int TtsetupTtsessionId { get; set; }

    public int TtsetupCmpId { get; set; }

    public int TtsetupSchId { get; set; }

    public int? TtsetupFruitReccessDuration { get; set; }

    public int? TtsetupFruitReccessAfterPeriod { get; set; }

    public string? TtsetupSession { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual TimeTableSession TtsetupTtsession { get; set; } = null!;
}
