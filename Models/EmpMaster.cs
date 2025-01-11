using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpMaster
{
    public int EmpId { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpGender { get; set; }

    public DateTime EmpDob { get; set; }

    public DateTime EmpDoj { get; set; }

    public int? EmpProbationPeriod { get; set; }

    public DateTime? EmpConfirmationDate { get; set; }

    public string? EmpPanNumber { get; set; }

    public string? EmpEsicNumber { get; set; }

    public string? EmpPfNumber { get; set; }

    public string? EmpCurrentAddress { get; set; }

    public string? EmpPermanentAddress { get; set; }

    public string? EmpCurrentCity { get; set; }

    public string? EmpCurrentState { get; set; }

    public string? EmpPermanentCity { get; set; }

    public string? EmpPermanentState { get; set; }

    public string? EmpPhone { get; set; }

    public string? EmpMobile { get; set; }

    public string? EmpEmail { get; set; }

    public int EmpDeptId { get; set; }

    public int EmpDesigId { get; set; }

    public int? EmpPaymentModeId { get; set; }

    public int EmpTypeId { get; set; }

    public int EmpCatId { get; set; }

    public string? EmpBankAccountNumber { get; set; }

    public string? EmpBankName { get; set; }

    public int EmpSchId { get; set; }

    public int EmpCmpId { get; set; }

    public int? EmpBloodGroupId { get; set; }

    public int EmpGradeId { get; set; }

    public string? EmpImage { get; set; }

    public string? EmpCurrentZipcode { get; set; }

    public string? EmpCurrentCountry { get; set; }

    public string? EmpPermanentZipcode { get; set; }

    public string? EmpPermanentCountry { get; set; }

    public int? EmpOldId { get; set; }

    public string? EmpFathersName { get; set; }

    public string? EmpDescription { get; set; }

    public string? EmpLicenceNumber { get; set; }

    public DateTime? EmpLicenceIssueDate { get; set; }

    public DateTime? EmpLicenceValidDate { get; set; }

    public string? EmpLicenceDescription { get; set; }

    public string? EmpLicenceImage { get; set; }

    public string? EmpLicenceType { get; set; }

    public string? EmpSalutation { get; set; }

    public DateTime? EmpDateOfLeaving { get; set; }

    public string? EmpMartialStatus { get; set; }

    public string? EmpYearsOfExperiecne { get; set; }

    public string? EmpPreviousSchoolCompany { get; set; }

    public string? EmpAadharNumber { get; set; }

    public int? EmpCategoryId { get; set; }

    public int? EmpMathsUptoClass { get; set; }

    public int? EmpEnglishUptoClass { get; set; }

    public int? EmpSstUptoClass { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<EmpAttendanceDetail> EmpAttendanceDetails { get; set; } = new List<EmpAttendanceDetail>();

    public virtual ICollection<EmpAttendanceDetailsHistory> EmpAttendanceDetailsHistories { get; set; } = new List<EmpAttendanceDetailsHistory>();

    public virtual EmpCategoryMaster EmpCat { get; set; } = null!;

    public virtual DeptMaster EmpDept { get; set; } = null!;

    public virtual DeptDesigDetail EmpDesig { get; set; } = null!;

    public virtual ICollection<EmpDocumentDetail> EmpDocumentDetails { get; set; } = new List<EmpDocumentDetail>();

    public virtual ICollection<EmpLeaveAvailDetail> EmpLeaveAvailDetails { get; set; } = new List<EmpLeaveAvailDetail>();

    public virtual ICollection<EmpLeaveDetail> EmpLeaveDetails { get; set; } = new List<EmpLeaveDetail>();

    public virtual ICollection<EmpLeaveDetailsHistory> EmpLeaveDetailsHistories { get; set; } = new List<EmpLeaveDetailsHistory>();

    public virtual PaymentModeMaster? EmpPaymentMode { get; set; }

    public virtual ICollection<EmpProfQualiDetail> EmpProfQualiDetails { get; set; } = new List<EmpProfQualiDetail>();

    public virtual ICollection<EmpSalaryStructureDetail> EmpSalaryStructureDetails { get; set; } = new List<EmpSalaryStructureDetail>();

    public virtual ICollection<EmpSalaryStructureDetailsHistory> EmpSalaryStructureDetailsHistories { get; set; } = new List<EmpSalaryStructureDetailsHistory>();

    public virtual EmpTypeMaster EmpType { get; set; } = null!;

    public virtual ICollection<TimeTableDetailsHistory> TimeTableDetailsHistories { get; set; } = new List<TimeTableDetailsHistory>();

    public virtual ICollection<TimeTableSubstitutionDetail> TimeTableSubstitutionDetailTtsubsdTeacherIdNewNavigations { get; set; } = new List<TimeTableSubstitutionDetail>();

    public virtual ICollection<TimeTableSubstitutionDetail> TimeTableSubstitutionDetailTtsubsdTeachers { get; set; } = new List<TimeTableSubstitutionDetail>();

    public virtual ICollection<TimeTableSubstitutionDetailsHistory> TimeTableSubstitutionDetailsHistoryTtsubsdhTeacherIdNewNavigations { get; set; } = new List<TimeTableSubstitutionDetailsHistory>();

    public virtual ICollection<TimeTableSubstitutionDetailsHistory> TimeTableSubstitutionDetailsHistoryTtsubsdhTeachers { get; set; } = new List<TimeTableSubstitutionDetailsHistory>();
}
