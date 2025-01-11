using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpSalaryDetailsHistory
{
    public int EsaldhId { get; set; }

    public int EsaldhEsalmId { get; set; }

    public int? EsaldhSalhmId { get; set; }

    public int? EsaldhDesgradeId { get; set; }

    public decimal? EsaldhValue { get; set; }

    public string? EsaldhSalaryType { get; set; }

    public bool EsaldhIsDeduction { get; set; }

    public string? EsaldhSalCode { get; set; }

    public string? EsaldhSalDescription { get; set; }

    public decimal? EsaldhAmount { get; set; }

    public string? EsaldhIsSalaryHead { get; set; }

    public int EsaldhCmpId { get; set; }

    public int EsaldhSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
