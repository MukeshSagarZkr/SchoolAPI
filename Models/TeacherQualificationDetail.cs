using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TeacherQualificationDetail
{
    public int TqualdTeacherId { get; set; }

    public int TqualdQualId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual QualificationMaster TqualdQual { get; set; } = null!;

    public virtual TeacherMaster TqualdTeacher { get; set; } = null!;
}
