using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpSalaryMaster
{
    public int EsalmId { get; set; }

    public int EsalmEmpId { get; set; }

    public int EsalmMonth { get; set; }

    public int EsalmYear { get; set; }

    public string EsalmSession { get; set; } = null!;

    public DateTime EsalmBatchprintDate { get; set; }

    public decimal? EsalmBasicSalary { get; set; }

    public decimal? EsalmAllowances { get; set; }

    public decimal? EsalmDeductions { get; set; }

    public decimal? EsalmNetSalary { get; set; }

    public int EsalmTotalDays { get; set; }

    public decimal? EsalmPresentDays { get; set; }

    public decimal? EsalmAbsentDays { get; set; }

    public decimal? EsalmLeaveDays { get; set; }

    public string? EsalmLeaveDesc { get; set; }

    public string? EsalmLeaveBalanceDesc { get; set; }

    public decimal? EsalmPerDaySalary { get; set; }

    public int? EsalmDeptId { get; set; }

    public int? EsalmDesigId { get; set; }

    public int? EsalmGradeId { get; set; }

    public int EsalmCmpId { get; set; }

    public int EsalmSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
