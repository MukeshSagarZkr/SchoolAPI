using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class AssesmentMaster
{
    public int AssesmentId { get; set; }

    public string? AssesmentName { get; set; }

    public string? AssesmentDesc { get; set; }

    public decimal? AssesmentPercentageWeightage { get; set; }

    public DateTime? AssesmentFromPeriod { get; set; }

    public DateTime? AssesmentToPeriod { get; set; }

    public int AssesmentCmpId { get; set; }

    public int AssesmentSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
