using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpSalaryStructureDetail
{
    public int EssdId { get; set; }

    public int EssdEmpId { get; set; }

    public int EssdSalhmId { get; set; }

    public int EssdDesgradeId { get; set; }

    public string? EssdSession { get; set; }

    public decimal? EssdValue { get; set; }

    public string EssdSalaryType { get; set; } = null!;

    public bool EssdIsDeductance { get; set; }

    public string? EssdSalhCode { get; set; }

    public string? EsddSalhDescription { get; set; }

    public bool? EsddSalhIsReadonly { get; set; }

    public int EsddCmpId { get; set; }

    public int EsddSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual DesigGradeDetail EssdDesgrade { get; set; } = null!;

    public virtual EmpMaster EssdEmp { get; set; } = null!;
}
