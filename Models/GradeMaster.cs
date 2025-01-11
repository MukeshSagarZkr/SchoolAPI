using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class GradeMaster
{
    public int GradeId { get; set; }

    public string? GradeName { get; set; }

    public string? GradeDesc { get; set; }

    public int GradeCmpId { get; set; }

    public int GradeSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<DesigGradeDetail> DesigGradeDetails { get; set; } = new List<DesigGradeDetail>();
}
