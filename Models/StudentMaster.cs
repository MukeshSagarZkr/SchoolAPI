using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentMaster
{
    public Guid StuGuid { get; set; }

    public int StuRollNumber { get; set; }

    public string? StuFirstName { get; set; }

    public string? StuLastName { get; set; }

    public string? StuAddress { get; set; }

    public string? StuCity { get; set; }

    public string? StuState { get; set; }

    public string? StuZipCode { get; set; }

    public string? StuCountry { get; set; }

    public string? StuContactNumber { get; set; }

    public string? StuEmergencyContactNumber { get; set; }

    public DateTime StuDob { get; set; }

    public DateTime StuDoj { get; set; }

    public string StuRegstrationNumber { get; set; } = null!;

    public int StuCmId { get; set; }

    public int StuSecId { get; set; }

    public string? StuHouseAllotted { get; set; }

    public string? StuTransport { get; set; }

    public string? StuImage { get; set; }

    public string? StuEmail { get; set; }

    public int StuCatId { get; set; }

    public string? StuSiblingIfAny { get; set; }

    public int? StuSiblingCmId { get; set; }

    public string? StuGender { get; set; }

    public string? StuDisabilityAny { get; set; }

    public string? StuMedicalAlergiesAny { get; set; }

    public string? StuBirthPlace { get; set; }

    public string? StuBirthCountry { get; set; }

    public string? StuPreviousSchoolAttended { get; set; }

    public string? StuPreviousSchoolClass { get; set; }

    public decimal? StuPreviousSchoolPercentage { get; set; }

    public string? StuPreviousSchoolRank { get; set; }

    public int? StuPreviousSchoolBoardId { get; set; }

    public DateTime? StuPreviousSchoolFromDate { get; set; }

    public DateTime? StuPreviousSchoolToDate { get; set; }

    public int StuCmpId { get; set; }

    public int StuSchId { get; set; }

    public DateTime? StuWithdrawnDate { get; set; }

    public string? StuWithdrawnReason { get; set; }

    public string? StuBloodGroup { get; set; }

    public string? StuNationality { get; set; }

    public string? StuHobbies { get; set; }

    public string? StuReligion { get; set; }

    public string? StuPhone { get; set; }

    public int? StuCityId { get; set; }

    public int? StuStateId { get; set; }

    public int? StuBloodGroupId { get; set; }

    public int? StuReligionId { get; set; }

    public int? StuRouteId { get; set; }

    public int? StuRouteStopId { get; set; }

    public int? StuClassTeacherId { get; set; }

    public int? StuRoutePickAndDrop { get; set; }

    public int? StuFdcmId { get; set; }

    public decimal? StuTutionFees { get; set; }

    public decimal? StuAnnualFfes { get; set; }

    public decimal? StuTransportFees { get; set; }

    public bool? StuUseTransportFees { get; set; }

    public bool? StuIsActive { get; set; }

    public string? StuSession { get; set; }

    public DateTime? StuTransportAvailingDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BookTransactionDetail> BookTransactionDetails { get; set; } = new List<BookTransactionDetail>();

    public virtual ICollection<StudentAttendanceDetail> StudentAttendanceDetails { get; set; } = new List<StudentAttendanceDetail>();

    public virtual ICollection<StudentAttendanceDetailsHistory> StudentAttendanceDetailsHistories { get; set; } = new List<StudentAttendanceDetailsHistory>();
}
