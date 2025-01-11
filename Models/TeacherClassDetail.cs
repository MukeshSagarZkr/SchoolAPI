using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TeacherClassDetail
{
    public int TcdId { get; set; }

    public int TcdTeacherId { get; set; }

    public int TcdClassId { get; set; }

    public int TcdSectionId { get; set; }

    public int TcdSubjectId { get; set; }

    public int TcdCmpId { get; set; }

    public int TcdSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TcdClass { get; set; } = null!;

    public virtual SectionMaster TcdSection { get; set; } = null!;

    public virtual SubjectMaster TcdSubject { get; set; } = null!;

    public virtual TeacherMaster TcdTeacher { get; set; } = null!;
}
