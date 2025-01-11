using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class DesigMaster
{
    public int DesigId { get; set; }

    public string? DesigCode { get; set; }

    public string? DesigName { get; set; }

    public int DesigCmpId { get; set; }

    public int DesigSchId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<DeptDesigDetail> DeptDesigDetails { get; set; } = new List<DeptDesigDetail>();

    public virtual ICollection<DesigGradeDetail> DesigGradeDetails { get; set; } = new List<DesigGradeDetail>();
}
