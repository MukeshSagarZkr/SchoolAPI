using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TimeTableSession
{
    public int TtsessionId { get; set; }

    public string? TtsessionName { get; set; }

    public string? TtsesstionDescription { get; set; }

    public int TtsessionCmpId { get; set; }

    public int TtsessionSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<TimeTableClassPeriodDetail> TimeTableClassPeriodDetails { get; set; } = new List<TimeTableClassPeriodDetail>();

    public virtual ICollection<TimeTableClassPeriodDetailsHistory> TimeTableClassPeriodDetailsHistories { get; set; } = new List<TimeTableClassPeriodDetailsHistory>();

    public virtual ICollection<TimeTableDetailsHistory> TimeTableDetailsHistories { get; set; } = new List<TimeTableDetailsHistory>();

    public virtual ICollection<TimeTablePeriodMasterHistory> TimeTablePeriodMasterHistories { get; set; } = new List<TimeTablePeriodMasterHistory>();

    public virtual ICollection<TimeTablePeriodMaster> TimeTablePeriodMasters { get; set; } = new List<TimeTablePeriodMaster>();

    public virtual ICollection<TimeTableSetupDetail> TimeTableSetupDetails { get; set; } = new List<TimeTableSetupDetail>();

    public virtual ICollection<TimeTableSetupDetailsHistory> TimeTableSetupDetailsHistories { get; set; } = new List<TimeTableSetupDetailsHistory>();

    public virtual ICollection<TimeTableSubstitutionDetail> TimeTableSubstitutionDetails { get; set; } = new List<TimeTableSubstitutionDetail>();

    public virtual ICollection<TimeTableSubstitutionDetailsHistory> TimeTableSubstitutionDetailsHistories { get; set; } = new List<TimeTableSubstitutionDetailsHistory>();
}
