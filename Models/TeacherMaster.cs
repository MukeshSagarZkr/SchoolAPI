using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TeacherMaster
{
    public int TeacherId { get; set; }

    public string TeacherFirstName { get; set; } = null!;

    public string? TeacherLastName { get; set; }

    public DateTime TeacherDob { get; set; }

    public DateTime? TeacherDoj { get; set; }

    public DateTime? TeacherDateOfLeaving { get; set; }

    public string? TeacherAddress { get; set; }

    public string? TeacherCity { get; set; }

    public string? TeacherState { get; set; }

    public string? TeacherZipcode { get; set; }

    public string TeacherGender { get; set; } = null!;

    public string? TeacherMartialStatus { get; set; }

    public string? TeacherImage { get; set; }

    public int? TeacherCityId { get; set; }

    public int? TeacherStateId { get; set; }

    public string? TeacherPhone { get; set; }

    public string? TeacherMobilePhone { get; set; }

    public string? TeacherYearsOfExperience { get; set; }

    public string? TeacherPreviousSchool { get; set; }

    public string? TeacherSalutation { get; set; }

    public string? TeacherEmail { get; set; }

    public int TeacherCmpId { get; set; }

    public int TeacherSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<TeacherClassDetail> TeacherClassDetails { get; set; } = new List<TeacherClassDetail>();

    public virtual ICollection<TeacherDocumentDetail> TeacherDocumentDetails { get; set; } = new List<TeacherDocumentDetail>();

    public virtual ICollection<TeacherQualificationDetail> TeacherQualificationDetails { get; set; } = new List<TeacherQualificationDetail>();

    public virtual ICollection<TeacherSectionDetail> TeacherSectionDetails { get; set; } = new List<TeacherSectionDetail>();

    public virtual ICollection<TeacherSubjectDetail> TeacherSubjectDetails { get; set; } = new List<TeacherSubjectDetail>();
}
