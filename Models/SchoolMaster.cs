using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SchoolMaster
{
    public int SchId { get; set; }

    public string? SchName { get; set; }

    public string? SchDescription { get; set; }

    public string? SchEmail { get; set; }

    public string? SchAddress { get; set; }

    public string? SchCity { get; set; }

    public string? SchState { get; set; }

    public string? SchCountry { get; set; }

    public string? SchZipcode { get; set; }

    public string? SchPhone { get; set; }

    public string? SchMobile { get; set; }

    public int SchCmpId { get; set; }

    public int? SchStateId { get; set; }

    public int? SchCityId { get; set; }

    public DateTime? SchEstablishmentYear { get; set; }

    public string? SchJurisdictionArea { get; set; }

    public string? SchBankAddress { get; set; }

    public string? SchBankAccountNumber { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
