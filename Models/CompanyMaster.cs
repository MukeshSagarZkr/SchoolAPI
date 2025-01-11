using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class CompanyMaster
{
    public int CmpId { get; set; }

    public string? CmpName { get; set; }

    public string? CmpDescription { get; set; }

    public string? CmpAddress { get; set; }

    public string? CmpCity { get; set; }

    public string? CmpState { get; set; }

    public string? CmpCountry { get; set; }

    public string? CmpEmail { get; set; }

    public int? CmpStateId { get; set; }

    public int? CmpCityId { get; set; }

    public string? CmpEstablishmentYear { get; set; }

    public string? CmpJurisdictionArea { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
