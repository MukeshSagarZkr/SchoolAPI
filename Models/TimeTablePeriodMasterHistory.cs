using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTablePeriodMasterHistory
{
    public int TtperiodhId { get; set; }

    public int TtperiodhPeriodId { get; set; }

    public string TtperiodhDesctiption { get; set; } = null!;

    public int TtperiodhNumber { get; set; }

    public TimeOnly TtperiodhStartTime { get; set; }

    public TimeOnly TtperiodhEndTime { get; set; }

    public int TtperiodhTtsessionId { get; set; }

    public string? TtperiodhSession { get; set; }

    public int TtperiodhCmpId { get; set; }

    public int TtperiodhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual TimeTableSession TtperiodhTtsession { get; set; } = null!;
}
