using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class RegistrationMaster
{
    public int RegId { get; set; }

    public string? RegNumber { get; set; }

    public string? RegFirstName { get; set; }

    public string? RegLastName { get; set; }

    public DateTime RegDob { get; set; }

    public decimal RegAge { get; set; }

    public int RegCmId { get; set; }

    public DateTime RegDate { get; set; }

    public string? RegSession { get; set; }

    public string? RegAddress { get; set; }

    public string? RegCity { get; set; }

    public string? RegState { get; set; }

    public int? RegCityId { get; set; }

    public int? RegStateId { get; set; }

    public int? RegReligionId { get; set; }

    public string? RegReligion { get; set; }

    public int? RegCatId { get; set; }

    public string? RegGender { get; set; }

    public bool? RegIsActive { get; set; }

    public int? RegBloodGroupId { get; set; }

    public string? RegBloodGroup { get; set; }

    public string? RegContactNumber { get; set; }

    public string? RegEmail { get; set; }

    public string? RegPhone { get; set; }

    public string? RegAgeInWords { get; set; }

    public decimal? RegFees { get; set; }

    public bool? RegFeesPaid { get; set; }

    public string? RegSiblingIfAny { get; set; }

    public int? RegSiblingCmId { get; set; }

    public string? RegFatherFirstName { get; set; }

    public string? RegFatherLastName { get; set; }

    public DateTime? RegFatherDob { get; set; }

    public int? RegFatherQualiId { get; set; }

    public string? RegFatherOccupation { get; set; }

    public string? RegFatherDesignation { get; set; }

    public decimal? RegFatherIncome { get; set; }

    public string? RegMotherFirstName { get; set; }

    public string? RegMotherLastName { get; set; }

    public DateTime? RegMotherDob { get; set; }

    public int? RegMotherQualiId { get; set; }

    public string? RegMotherOccupation { get; set; }

    public string? RegMotherDesignation { get; set; }

    public decimal? RegMotherIncome { get; set; }

    public bool? RegBirthCertificate { get; set; }

    public bool? RegTransferCertificate { get; set; }

    public bool? RegReportCard { get; set; }

    public bool? RegOtherCertificate { get; set; }

    public string? RegOtherDescription { get; set; }

    public bool? RegIsAdmConfirmed { get; set; }

    public Guid? RegStuGuid { get; set; }

    public int RegCmpId { get; set; }

    public int RegSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual CategoryMaster? RegCat { get; set; }

    public virtual ClassMaster RegCm { get; set; } = null!;
}
