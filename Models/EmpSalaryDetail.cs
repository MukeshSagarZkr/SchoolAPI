using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpSalaryDetail
{
    public int EsaldId { get; set; }

    public int EsaldEsalmId { get; set; }

    public int? EsaldSalhmId { get; set; }

    public int? EsaldDesgradeId { get; set; }

    public decimal? EsaldValue { get; set; }

    public string? EsaldSalaryType { get; set; }

    public bool EsaldIsDeduction { get; set; }

    public string? EsaldSalCode { get; set; }

    public string? EsaldSalDescription { get; set; }

    public decimal? EsaldAmount { get; set; }

    public string? EsaldIsSalaryHead { get; set; }

    public int EsaldCmpId { get; set; }

    public int EsaldSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
