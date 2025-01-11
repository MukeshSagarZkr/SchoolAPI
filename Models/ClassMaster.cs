using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ClassMaster
{
    public int CmId { get; set; }

    public string? CmName { get; set; }

    public int CmCmpId { get; set; }

    public int CmSchId { get; set; }

    public int? CmOrderBy { get; set; }

    public string? CmExamAssesment { get; set; }

    public bool? CmIsGradePointApplicable { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BookTransactionDetail> BookTransactionDetails { get; set; } = new List<BookTransactionDetail>();

    public virtual ICollection<ClassScholasticDetail> ClassScholasticDetails { get; set; } = new List<ClassScholasticDetail>();

    public virtual ICollection<ClassSmstasksDetail> ClassSmstasksDetails { get; set; } = new List<ClassSmstasksDetail>();

    public virtual ICollection<FeeClassDetailsHistory> FeeClassDetailsHistories { get; set; } = new List<FeeClassDetailsHistory>();

    public virtual ICollection<HolidayClassDetail> HolidayClassDetails { get; set; } = new List<HolidayClassDetail>();

    public virtual ICollection<RegistrationMaster> RegistrationMasters { get; set; } = new List<RegistrationMaster>();

    public virtual ICollection<StudentAttendanceDetail> StudentAttendanceDetails { get; set; } = new List<StudentAttendanceDetail>();

    public virtual ICollection<StudentAttendanceDetailsHistory> StudentAttendanceDetailsHistories { get; set; } = new List<StudentAttendanceDetailsHistory>();

    public virtual ICollection<StudentMasterHistory> StudentMasterHistories { get; set; } = new List<StudentMasterHistory>();

    public virtual ICollection<TeacherClassDetail> TeacherClassDetails { get; set; } = new List<TeacherClassDetail>();

    public virtual ICollection<TeacherSectionDetail> TeacherSectionDetails { get; set; } = new List<TeacherSectionDetail>();

    public virtual ICollection<TimeTableClassPeriodDetail> TimeTableClassPeriodDetails { get; set; } = new List<TimeTableClassPeriodDetail>();

    public virtual ICollection<TimeTableClassPeriodDetailsHistory> TimeTableClassPeriodDetailsHistories { get; set; } = new List<TimeTableClassPeriodDetailsHistory>();

    public virtual ICollection<TimeTableDetailsHistory> TimeTableDetailsHistories { get; set; } = new List<TimeTableDetailsHistory>();

    public virtual ICollection<TimeTableSubstitutionDetail> TimeTableSubstitutionDetails { get; set; } = new List<TimeTableSubstitutionDetail>();

    public virtual ICollection<TimeTableSubstitutionDetailsHistory> TimeTableSubstitutionDetailsHistories { get; set; } = new List<TimeTableSubstitutionDetailsHistory>();
}
