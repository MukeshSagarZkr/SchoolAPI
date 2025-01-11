using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpSalaryStructureDetailsHistory
{
    public int EssdhId { get; set; }

    public int EssdhEmpId { get; set; }

    public int EssdhSalhmId { get; set; }

    public int EssdhDesgradeId { get; set; }

    public string? EssdhSession { get; set; }

    public decimal? EssdhValue { get; set; }

    public bool EssdhIsActive { get; set; }

    public string EssdhSalaryType { get; set; } = null!;

    public bool EssdhIsDeductance { get; set; }

    public string? EssdhSalhCode { get; set; }

    public string? EsddhSalhDescription { get; set; }

    public bool? EsddhSalhIsReadonly { get; set; }

    public int EsddhCmpId { get; set; }

    public int EsddhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DesigGradeDetail EssdhDesgrade { get; set; } = null!;

    public virtual EmpMaster EssdhEmp { get; set; } = null!;
}
