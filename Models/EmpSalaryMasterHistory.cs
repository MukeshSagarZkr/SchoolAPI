using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpSalaryMasterHistory
{
    public int EsalmhId { get; set; }

    public int EsalmhEsalmId { get; set; }

    public int EsalmhEmpId { get; set; }

    public int EsalmhMonth { get; set; }

    public int EsalmhYear { get; set; }

    public string EsalmhSession { get; set; } = null!;

    public DateTime EsalmhBatchprintDate { get; set; }

    public decimal? EsalmhBasicSalary { get; set; }

    public decimal? EsalmhAllowances { get; set; }

    public decimal? EsalmhDeductions { get; set; }

    public decimal? EsalmhNetSalary { get; set; }

    public int EsalmhTotalDays { get; set; }

    public decimal? EsalmhPresentDays { get; set; }

    public decimal? EsalmhAbsentDays { get; set; }

    public decimal? EsalmhLeaveDays { get; set; }

    public string? EsalmhLeaveDesc { get; set; }

    public string? EsalmhLeaveBalanceDesc { get; set; }

    public decimal? EsalmhPerDaySalary { get; set; }

    public int? EsalmhDeptId { get; set; }

    public int? EsalmhDesigId { get; set; }

    public int? EsalmhGradeId { get; set; }

    public int EsalmhCmpId { get; set; }

    public int EsalmhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
