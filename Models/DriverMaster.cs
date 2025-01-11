using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class DriverMaster
{
    public int DriverId { get; set; }

    public string DriverFirstName { get; set; } = null!;

    public string? DriverLastName { get; set; }

    public DateTime? DriverDob { get; set; }

    public int? DriverQualId { get; set; }

    public string? DriverMobilePhone { get; set; }

    public string? DriverAddress { get; set; }

    public string? DriverPhone { get; set; }

    public string? DriverCity { get; set; }

    public string? DriverState { get; set; }

    public string? DriverZipcode { get; set; }

    public string? DriverImage { get; set; }

    public int DriverCmpId { get; set; }

    public int DriverSchId { get; set; }

    public int? DriverCityId { get; set; }

    public int? DriverStateId { get; set; }

    public string? DriverLicenceNumber { get; set; }

    public DateTime? DriverLicenceIssueDate { get; set; }

    public DateTime? DriverLicenceValidDate { get; set; }

    public string? DriverLicenceDescription { get; set; }

    public string? DriverLicenceImage { get; set; }

    public string? DriverLicenceType { get; set; }

    public string? DriverFatherName { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
