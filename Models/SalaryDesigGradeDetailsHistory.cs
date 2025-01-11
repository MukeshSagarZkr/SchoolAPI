using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SalaryDesigGradeDetailsHistory
{
    public int SaldgdhId { get; set; }

    public int SaldgdhDesgradeId { get; set; }

    public int SaldgdhSalhmId { get; set; }

    public decimal? SaldgdhValue { get; set; }

    public string? SaldgdhSession { get; set; }

    public int SaldgdhCmpId { get; set; }

    public int SaldgdhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DesigGradeDetail SaldgdhDesgrade { get; set; } = null!;

    public virtual SalaryHeadMaster SaldgdhSalhm { get; set; } = null!;
}
