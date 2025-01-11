using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class TeacherSectionDetail
{
    public int TsecId { get; set; }

    public int TsecTeacherId { get; set; }

    public int TsecSecId { get; set; }

    public int TsecCmId { get; set; }

    public int TsecSubId { get; set; }

    public bool TsecIsClassTeacher { get; set; }

    public int TsecSchId { get; set; }

    public int TsecCmpId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ClassMaster TsecCm { get; set; } = null!;

    public virtual ClassSectionDetail TsecSec { get; set; } = null!;

    public virtual SubjectMaster TsecSub { get; set; } = null!;

    public virtual TeacherMaster TsecTeacher { get; set; } = null!;
}
