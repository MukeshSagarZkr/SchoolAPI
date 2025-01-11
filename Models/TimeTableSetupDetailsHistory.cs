using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableSetupDetailsHistory
{
    public int TtsetuphId { get; set; }

    public TimeOnly TtsetuphSchoolStartTime { get; set; }

    public TimeOnly TtsetuphSchoolEndTime { get; set; }

    public TimeOnly TtsetuphPeriodStartTime { get; set; }

    public int TtsetuphTotalPeriods { get; set; }

    public int TtsetuphPeriodDuration { get; set; }

    public int TtsetuphReccessDuration { get; set; }

    public int TtsetuphReccessAfterPeriod { get; set; }

    public int TtsetuphTtsessionId { get; set; }

    public int? TtsetuphFruitReccessDuration { get; set; }

    public int? TtsetuphFruitReccessAfterPeriod { get; set; }

    public string? TtsetuphSession { get; set; }

    public int TtsetuphCmpId { get; set; }

    public int TtsetuphSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual TimeTableSession TtsetuphTtsession { get; set; } = null!;
}
