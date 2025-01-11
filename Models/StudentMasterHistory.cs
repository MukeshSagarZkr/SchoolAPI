using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentMasterHistory
{
    public Guid StuhGuid { get; set; }

    public int StuhRollNumber { get; set; }

    public string? StuhFirstName { get; set; }

    public string? StuhLastName { get; set; }

    public string? StuhAddress { get; set; }

    public string? StuhCity { get; set; }

    public string? StuhState { get; set; }

    public string? StuhZipCode { get; set; }

    public string? StuhCountry { get; set; }

    public string? StuhContactNumber { get; set; }

    public string? StuhEmergencyContactNumber { get; set; }

    public DateTime StuhDob { get; set; }

    public DateTime StuhDoj { get; set; }

    public string StuhRegstrationNumber { get; set; } = null!;

    public int StuhCmId { get; set; }

    public int StuhSecId { get; set; }

    public string? StuhHouseAllotted { get; set; }

    public string? StuhTransport { get; set; }

    public string? StuhImage { get; set; }

    public string? StuhEmail { get; set; }

    public int StuhCatId { get; set; }

    public string? StuhSiblingIfAny { get; set; }

    public int? StuhSiblingCmId { get; set; }

    public string? StuhGender { get; set; }

    public string? StuhDisabilityAny { get; set; }

    public string? StuhMedicalAlergiesAny { get; set; }

    public string? StuhBirthPlace { get; set; }

    public string? StuhBirthCountry { get; set; }

    public string? StuhPreviousSchoolAttended { get; set; }

    public string? StuhPreviousSchoolClass { get; set; }

    public decimal? StuhPreviousSchoolPercentage { get; set; }

    public string? StuhPreviousSchoolRank { get; set; }

    public int? StuhPreviousSchoolBoardId { get; set; }

    public DateTime? StuhPreviousSchoolFromDate { get; set; }

    public DateTime? StuhPreviousSchoolToDate { get; set; }

    public int StuhCmpId { get; set; }

    public int StuhSchId { get; set; }

    public DateTime? StuhWithdrawnDate { get; set; }

    public string? StuhWithdrawnReason { get; set; }

    public string? StuhBloodGroup { get; set; }

    public string? StuhNationality { get; set; }

    public string? StuhHobbies { get; set; }

    public string? StuhReligion { get; set; }

    public string? StuhPhone { get; set; }

    public int? StuhCityId { get; set; }

    public int? StuhStateId { get; set; }

    public int? StuhBloodGroupId { get; set; }

    public int? StuhReligionId { get; set; }

    public int? StuhRouteId { get; set; }

    public int? StuhRouteStopId { get; set; }

    public int? StuhClassTeacherId { get; set; }

    public int? StuhRoutePickAndDrop { get; set; }

    public int? StuhFdcmId { get; set; }

    public decimal? StuhTutionFees { get; set; }

    public decimal? StuhAnnualFfes { get; set; }

    public decimal? StuhTransportFees { get; set; }

    public bool? StuhUseTransportFees { get; set; }

    public bool? StuhIsActive { get; set; }

    public string StuhSession { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster StuhCm { get; set; } = null!;
}
