using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SalaryDesigGradeDetail
{
    public int SaldgdId { get; set; }

    public int SaldgdDesgradeId { get; set; }

    public int SaldgdSalhmId { get; set; }

    public decimal? SaldgdValue { get; set; }

    public string? SaldgdSession { get; set; }

    public bool? SaldgdIsActive { get; set; }

    public int SaldgdCmpId { get; set; }

    public int SaldgdSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DesigGradeDetail SaldgdDesgrade { get; set; } = null!;

    public virtual SalaryHeadMaster SaldgdSalhm { get; set; } = null!;
}
