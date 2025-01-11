using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ParentMaster
{
    public int PmId { get; set; }

    public Guid PmStuGuid { get; set; }

    public string PmFirstName { get; set; } = null!;

    public string PmLastName { get; set; } = null!;

    public DateTime? PmDob { get; set; }

    public int? PmQualId { get; set; }

    public string? PmOccupation { get; set; }

    public decimal? PmIncome { get; set; }

    public string? PmDesignation { get; set; }

    public string? PmPhone { get; set; }

    public string? PmMobile { get; set; }

    public string? PmEmail { get; set; }

    public string? PmAddress { get; set; }

    public string? PmCity { get; set; }

    public string? PmState { get; set; }

    public string? PmZipcode { get; set; }

    public string? PmOfficeAddress { get; set; }

    public string? PmOfficeCity { get; set; }

    public string? PmOfficeState { get; set; }

    public string? PmOfficeZipcode { get; set; }

    public string? PmOfficePhone { get; set; }

    public string? PmImage { get; set; }

    public string? PmRelationType { get; set; }

    public int PmSchId { get; set; }

    public int PmCmpId { get; set; }

    public int? PmCityId { get; set; }

    public int? PmStateId { get; set; }

    public int? PmOfficeCityId { get; set; }

    public int? PmOfficeStateId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
