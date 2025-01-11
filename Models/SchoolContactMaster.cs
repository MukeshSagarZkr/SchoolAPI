using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SchoolContactMaster
{
    public int SconmId { get; set; }

    public int SconmSchId { get; set; }

    public string? SconmFirstName { get; set; }

    public string? SconmLastName { get; set; }

    public string? SconmEmail { get; set; }

    public string? SconmMobilePhone { get; set; }

    public string? SconmAddressLine1 { get; set; }

    public string? SconmAddressLine2 { get; set; }

    public string? SconmPhone { get; set; }

    public string? SconmCity { get; set; }

    public string? SconmState { get; set; }

    public string? SconmCountry { get; set; }

    public int? SconmCityId { get; set; }

    public int? SconmStateId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
