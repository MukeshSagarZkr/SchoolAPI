using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TeacherSubjectDetail
{
    public int TsubdTeacherId { get; set; }

    public int TsubdSubId { get; set; }

    public int TsubdCmId { get; set; }

    public int? TsubdCmpId { get; set; }

    public int? TsubdSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual SubjectMaster TsubdSub { get; set; } = null!;

    public virtual TeacherMaster TsubdTeacher { get; set; } = null!;
}
