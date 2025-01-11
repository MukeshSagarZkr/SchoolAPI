using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class QualificationMaster
{
    public int QualId { get; set; }

    public string? QualName { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<EmpProfQualiDetail> EmpProfQualiDetails { get; set; } = new List<EmpProfQualiDetail>();

    public virtual ICollection<TeacherQualificationDetail> TeacherQualificationDetails { get; set; } = new List<TeacherQualificationDetail>();
}
