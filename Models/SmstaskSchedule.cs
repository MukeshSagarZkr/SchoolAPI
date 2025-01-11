using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SmstaskSchedule
{
    public int StsScheduleId { get; set; }

    public int StsScheduleTaskId { get; set; }

    public bool StsScheduleSunday { get; set; }

    public bool StsScheduleMonday { get; set; }

    public bool StsScheduleTuesday { get; set; }

    public bool StsScheduleWednesday { get; set; }

    public bool StsScheduleThrusday { get; set; }

    public bool StsScheduleFriday { get; set; }

    public bool StsScheduleSaturday { get; set; }

    public DateTime? StsScheduleStarttime { get; set; }

    public int StsCmpId { get; set; }

    public int StsSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual Smstask StsScheduleTask { get; set; } = null!;
}
